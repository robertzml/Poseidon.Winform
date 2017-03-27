using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Core
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Core.DL;

    /// <summary>
    /// 分组含子节点控件
    /// </summary>
    public partial class GroupChildrenTree : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 是否显示查询框
        /// </summary>
        private bool showFindPanel = false;

        /// <summary>
        /// 是否层级显示组织
        /// </summary>
        private bool cascadeOrganization = false;

        /// <summary>
        /// 相关分组
        /// </summary>
        private List<Group> relateGroups;

        /// <summary>
        /// 相关组织
        /// </summary>
        private List<Organization> relateOrganizations;
        #endregion //Field

        #region Constructor
        public GroupChildrenTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置相关分组代码
        /// </summary>
        /// <param name="code">分组代码</param>
        public void SetGroupCode(string code)
        {
            this.relateGroups = CallerFactory<IGroupService>.Instance.FindWithChildrenByCode(code).ToList();
            if (this.relateGroups.Count == 0)
                throw new PoseidonException(ErrorCode.ObjectNotFound);

            this.tlGroup.BeginUnboundLoad();

            var top = relateGroups.Find(r => r.Code == code);

            // get all children organizations
            var groupItems = CallerFactory<IGroupService>.Instance.FindAllItems(top.Id);
            this.relateOrganizations = CallerFactory<IOrganizationService>.Instance.FindWithIds(groupItems.Select(r => r.OrganizationId).ToList()).ToList();

            var topNode = this.tlGroup.AppendNode(new object[] { top.Id, top.Name, 1 }, null);
            topNode.StateImageIndex = 0;
            topNode.HasChildren = true;

            var children = this.relateGroups.Where(r => r.ParentId == top.Id);
            foreach (var item in children)
            {
                var node = this.tlGroup.AppendNode(new object[] { item.Id, item.Name, 1 }, topNode);
                node.StateImageIndex = 0;
                node.HasChildren = true;
            }

            topNode.Expanded = true;
            this.tlGroup.EndUnboundLoad();
        }

        /// <summary>
        /// 获取当前选中行ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSelectId()
        {
            var node = this.tlGroup.Selection[0];
            if (node == null)
                return null;

            return node["colId"].ToString();
        }
        #endregion //Method

        #region Delegate
        /// <summary>
        /// 分组选择事件
        /// </summary>
        [Description("分组选择事件")]
        public event EventHandler GroupSelected;

        /// <summary>
        /// 组织选择事件
        /// </summary>
        [Description("组织选择事件")]
        public event EventHandler OrganizationSelected;
        #endregion //Delegate

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupChildrenTree_Load(object sender, EventArgs e)
        {
            this.tlGroup.OptionsFind.AlwaysVisible = this.showFindPanel;
        }

        /// <summary>
        /// 载入子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlGroup_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e)
        {
            var id = e.Node["colId"].ToString();
            int type = Convert.ToInt32(e.Node["colType"]);

            this.tlGroup.BeginUnboundLoad();

            if (type == 1)
            {
                e.Node.Nodes.Clear();

                var group = this.relateGroups.Find(r => r.Id == id); // the seleted group

                // load children group
                var children = this.relateGroups.Where(r => r.ParentId == id);
                foreach (var item in children)
                {
                    var node = this.tlGroup.AppendNode(new object[] { item.Id, item.Name, 1 }, e.Node);
                    node.StateImageIndex = 0;
                    node.HasChildren = true;
                }

                // load contain organization
                var orgs = this.relateOrganizations.Where(r => group.Items.Select(s => s.OrganizationId).Contains(r.Id));
                foreach (var item in group.Items.OrderBy(r => r.Sort))
                {
                    var org = orgs.Single(r => r.Id == item.OrganizationId);
                    if (org == null)
                        continue;

                    if (this.cascadeOrganization && !string.IsNullOrEmpty(org.ParentId))
                    {
                        if (orgs.Count(r => r.Id == org.ParentId) > 0)
                            continue;
                    }

                    var node = this.tlGroup.AppendNode(new object[] { org.Id, org.Name, 2 }, e.Node);
                    node.StateImageIndex = 1;

                    if (this.cascadeOrganization && orgs.Count(r => r.ParentId == org.Id) > 0)
                        node.HasChildren = true;
                    else
                        node.HasChildren = false;
                }
            }
            else if (type == 2)
            {
                e.Node.Nodes.Clear();

                var org = this.relateOrganizations.Find(r => r.Id == id); //the selected org
                var children = this.relateOrganizations.Where(r => r.ParentId == org.Id);

                foreach (var item in children)
                {
                    var node = this.tlGroup.AppendNode(new object[] { item.Id, item.Name, 2 }, e.Node);
                    node.StateImageIndex = 1;

                    if (this.cascadeOrganization && this.relateOrganizations.Count(r => r.ParentId == item.Id) > 0)
                        node.HasChildren = true;
                    else
                        node.HasChildren = false;
                }
            }

            this.tlGroup.EndUnboundLoad();
        }

        /// <summary>
        /// 选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlGroup_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            int type = Convert.ToInt32(e.Node["colType"]);
            if (type == 1)
            {
                GroupSelected?.Invoke(sender, e);
            }
            else if (type == 2)
            {
                OrganizationSelected?.Invoke(sender, e);
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示查询框
        /// </summary>
        [Description("是否显示查询框")]
        public bool ShowFindPanel
        {
            get
            {
                return this.showFindPanel;
            }
            set
            {
                this.showFindPanel = value;
            }
        }

        /// <summary>
        /// 是否层级显示组织
        /// </summary>
        [Description("是否层级显示组织")]
        public bool CascadeOrganization
        {
            get
            {
                return this.cascadeOrganization;
            }
            set
            {
                this.cascadeOrganization = value;
            }
        }
        #endregion //Property
    }
}
