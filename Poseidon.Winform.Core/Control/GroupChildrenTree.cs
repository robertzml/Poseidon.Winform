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
    using DevExpress.XtraTreeList.Nodes;
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
        /// 是否层级显示对象
        /// </summary>
        private bool cascadeEntity = false;

        /// <summary>
        /// 相关分组
        /// </summary>
        private List<Group> relateGroups;

        /// <summary>
        /// 相关组织对象
        /// </summary>
        private List<Organization> relateOrganizations;

        /// <summary>
        /// 相关建筑对象
        /// </summary>
        private List<Building> relateBuildings;

        /// <summary>
        /// 关联对象类型
        /// </summary>
        private ModelCategory modelCategory;
        #endregion //Field

        #region Constructor
        public GroupChildrenTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 增加分组节点
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="parentNode"></param>
        private void AppendGroupNodes(List<Group> nodes, TreeListNode parentNode)
        {
            foreach (var item in nodes)
            {
                var node = this.tlGroup.AppendNode(new object[] { item.Id, item.Name, 1 }, parentNode);
                node.StateImageIndex = 0;
                node.HasChildren = true;
            }
        }

        /// <summary>
        /// 增加分组下对象节点
        /// </summary>
        /// <param name="group"></param>
        /// <param name="parentNode"></param>
        private void AppendEntityNodes(Group group, TreeListNode parentNode)
        {
            foreach (var item in group.Items.OrderBy(r => r.Sort))
            {
                if (this.modelCategory == ModelCategory.Organization)
                {
                    var org = this.relateOrganizations.Single(r => r.Id == item.EntityId);
                    if (org == null)
                        continue;

                    if (this.cascadeEntity && !string.IsNullOrEmpty(org.ParentId))
                    {
                        if (relateOrganizations.Count(r => r.Id == org.ParentId) > 0)
                            continue;
                    }

                    var node = this.tlGroup.AppendNode(new object[] { org.Id, org.Name, 2 }, parentNode);
                    node.StateImageIndex = 1;

                    if (this.cascadeEntity && relateOrganizations.Count(r => r.ParentId == org.Id) > 0)
                        node.HasChildren = true;
                    else
                        node.HasChildren = false;
                }
                else if (this.modelCategory == ModelCategory.Building)
                {
                    var bul = this.relateBuildings.Single(r => r.Id == item.EntityId);
                    if (bul == null)
                        continue;

                    if (this.cascadeEntity && !string.IsNullOrEmpty(bul.ParentId))
                    {
                        if (relateBuildings.Count(r => r.Id == bul.ParentId) > 0)
                            continue;
                    }

                    var node = this.tlGroup.AppendNode(new object[] { bul.Id, bul.Name, 2 }, parentNode);
                    node.StateImageIndex = 1;

                    if (this.cascadeEntity && relateBuildings.Count(r => r.ParentId == bul.Id) > 0)
                        node.HasChildren = true;
                    else
                        node.HasChildren = false;
                }
            }
        }

        /// <summary>
        /// 增加对象子节点
        /// </summary>
        /// <param name="group"></param>
        /// <param name="parentNode"></param>
        private void AppendEntityNodes(string id, TreeListNode parentNode)
        {
            if (this.modelCategory == ModelCategory.Organization)
            {
                var org = this.relateOrganizations.Find(r => r.Id == id); //the selected org
                var children = this.relateOrganizations.Where(r => r.ParentId == org.Id);

                foreach (var item in children)
                {
                    var node = this.tlGroup.AppendNode(new object[] { item.Id, item.Name, 2 }, parentNode);
                    node.StateImageIndex = 1;

                    if (this.cascadeEntity && this.relateOrganizations.Count(r => r.ParentId == item.Id) > 0)
                        node.HasChildren = true;
                    else
                        node.HasChildren = false;
                }
            }
            else if (this.modelCategory == ModelCategory.Building)
            {
                var bul = this.relateBuildings.Find(r => r.Id == id); //the selected org
                var children = this.relateBuildings.Where(r => r.ParentId == bul.Id);

                foreach (var item in children)
                {
                    var node = this.tlGroup.AppendNode(new object[] { item.Id, item.Name, 2 }, parentNode);
                    node.StateImageIndex = 1;

                    if (this.cascadeEntity && this.relateBuildings.Count(r => r.ParentId == item.Id) > 0)
                        node.HasChildren = true;
                    else
                        node.HasChildren = false;
                }
            }
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置相关分组代码
        /// </summary>
        /// <param name="code">分组代码</param>
        /// <param name="cascadeEntity">是否级联显示</param>
        public void SetGroupCode(string code, bool cascadeEntity = false)
        {
            // load all groups include children
            this.relateGroups = CallerFactory<IGroupService>.Instance.FindWithChildrenByCode(code).ToList();
            if (this.relateGroups.Count == 0)
                throw new PoseidonException(ErrorCode.ObjectNotFound);

            var top = relateGroups.Find(r => r.Code == code);
            this.modelCategory = CallerFactory<IGroupService>.Instance.GetCategory(top);

            var groupItems = CallerFactory<IGroupService>.Instance.FindAllItems(top.Id).ToList();
            var ids = groupItems.Select(r => r.EntityId).ToList();
            switch (modelCategory)
            {
                case ModelCategory.Organization:
                    this.relateOrganizations = CallerFactory<IOrganizationService>.Instance.FindWithIds(ids).ToList();
                    break;
                case ModelCategory.Building:
                    this.relateBuildings = CallerFactory<IBuildingService>.Instance.FindWithIds(ids).ToList();
                    break;
            }

            this.cascadeEntity = cascadeEntity;

            this.tlGroup.BeginUnboundLoad();
            this.tlGroup.ClearNodes();

            var topNode = this.tlGroup.AppendNode(new object[] { top.Id, top.Name, 1 }, null);
            topNode.StateImageIndex = 0;
            topNode.HasChildren = true;

            var children = this.relateGroups.Where(r => r.ParentId == top.Id).ToList();
            AppendGroupNodes(children, topNode);

            topNode.Expanded = true;
            this.tlGroup.EndUnboundLoad();
        }

        /// <summary>
        /// 设置多个分组
        /// </summary>
        /// <param name="codes">分组代码</param>
        /// <param name="cascadeEntity">是否级联显示</param>
        public void SetGroupCodes(string[] codes, bool cascadeEntity = false)
        {
            // load all groups include children
            this.relateGroups = new List<Group>();
            for (int i = 0; i < codes.Length; i++)
            {
                var subgroup = CallerFactory<IGroupService>.Instance.FindWithChildrenByCode(codes[i]);
                this.relateGroups.AddRange(subgroup);
            }
            if (this.relateGroups.Count == 0)
                throw new PoseidonException(ErrorCode.ObjectNotFound);

            var tops = relateGroups.Where(r => codes.Contains(r.Code));

            this.modelCategory = CallerFactory<IGroupService>.Instance.GetCategory(tops.First());

            List<GroupItem> groupItems = new List<GroupItem>();
            foreach (var top in tops)
            {
                var items = CallerFactory<IGroupService>.Instance.FindAllItems(top.Id);
                groupItems.AddRange(items);
            }

            var ids = groupItems.Select(r => r.EntityId).ToList();
            switch (modelCategory)
            {
                case ModelCategory.Organization:
                    this.relateOrganizations = CallerFactory<IOrganizationService>.Instance.FindWithIds(ids).ToList();
                    break;
                case ModelCategory.Building:
                    this.relateBuildings = CallerFactory<IBuildingService>.Instance.FindWithIds(ids).ToList();
                    break;
            }

            this.cascadeEntity = cascadeEntity;

            this.tlGroup.BeginUnboundLoad();
            this.tlGroup.ClearNodes();

            foreach (var top in tops)
            {
                var topNode = this.tlGroup.AppendNode(new object[] { top.Id, top.Name, 1 }, null);
                topNode.StateImageIndex = 0;
                topNode.HasChildren = true;

                var children = this.relateGroups.Where(r => r.ParentId == top.Id).ToList();
                AppendGroupNodes(children, topNode);

                topNode.Expanded = true;
            }

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
        /// 对象选择事件
        /// </summary>
        [Description("对象选择事件")]
        public event EventHandler EntitySelected;
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

                var children = this.relateGroups.Where(r => r.ParentId == id).ToList();
                AppendGroupNodes(children, e.Node);

                AppendEntityNodes(group, e.Node);

            }
            else if (type == 2)
            {
                e.Node.Nodes.Clear();

                AppendEntityNodes(id, e.Node);
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
            if (e.Node == null)
                return;

            int type = Convert.ToInt32(e.Node["colType"]);
            if (type == 1)
            {
                GroupSelected?.Invoke(sender, e);
            }
            else if (type == 2)
            {
                EntitySelected?.Invoke(sender, e);
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
        /// 是否层级显示对象
        /// </summary>
        [Description("是否层级显示对象")]
        public bool CascadeEntity
        {
            get
            {
                return this.cascadeEntity;
            }
            set
            {
                this.cascadeEntity = value;
            }
        }
        #endregion //Property
    }
}
