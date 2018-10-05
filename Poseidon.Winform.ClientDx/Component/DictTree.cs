using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Caller.Facade;
    using Poseidon.Core.DL;

    /// <summary>
    /// 字典树形控件
    /// </summary>
    public partial class DictTree : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 相关分类
        /// </summary>
        private List<DictCategory> categories;
        #endregion //Field

        #region Constructor
        public DictTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入根节点
        /// </summary>
        private void LoadRootNode()
        {
            this.categories = CallerFactory<IDictCategoryService>.Instance.FindAll().ToList();

            this.tlData.BeginUnboundLoad();
            this.tlData.Nodes.Clear();

            foreach (var item in categories)
            {
                var node = this.tlData.AppendNode(new object[] { item.Id, item.Name, 1 }, null);
                node.StateImageIndex = 0;
                node.HasChildren = true;

                node.Expanded = true;
            }
            this.tlData.EndUnboundLoad();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化根节点
        /// </summary>
        public void InitRoot()
        {
            this.LoadRootNode();
        }

        /// <summary>
        /// 获取当前选中字典ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSelectDictId()
        {
            var node = this.tlData.Selection[0];
            if (node == null)
                return null;

            int type = Convert.ToInt32(node["colType"]);
            if (type == 2)
                return node["colId"].ToString();
            else
                return null;
        }

        /// <summary>
        /// 获取当前选中字典分类ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSelectCategoryId()
        {
            var node = this.tlData.Selection[0];
            if (node == null)
                return null;

            int type = Convert.ToInt32(node["colType"]);
            if (type == 1)
                return node["colId"].ToString();
            else
                return null;
        }

        /// <summary>
        /// 重新加载数据
        /// </summary>
        public void Reload()
        {
            this.LoadRootNode();
        }
        #endregion //Method

        #region Delegate
        /// <summary>
        /// 字典选择事件
        /// </summary>
        [Description("字典选择事件")]
        public event EventHandler DictSelected;

        /// <summary>
        /// 分类选择事件
        /// </summary>
        [Description("分类选择事件")]
        public event EventHandler CategorySelected;
        #endregion //Delegate

        #region Event
        /// <summary>
        /// 节点展开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlData_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e)
        {
            var id = e.Node["colId"].ToString();
            int type = Convert.ToInt32(e.Node["colType"]);

            if (type == 1)
            {
                this.tlData.BeginUnboundLoad();
                e.Node.Nodes.Clear();

                // load contain dict
                var dicts = CallerFactory<IDictService>.Instance.FindByCategory(id);

                foreach (var item in dicts)
                {
                    var node = this.tlData.AppendNode(new object[] { item.Id, item.Name, 2 }, e.Node);
                    node.StateImageIndex = 1;
                    node.HasChildren = false;
                }

                this.tlData.EndUnboundLoad();
            }
        }

        /// <summary>
        /// 节点选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlData_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null)
                return;

            int type = Convert.ToInt32(e.Node["colType"]);
            if (type == 1)
            {
                CategorySelected?.Invoke(sender, e);
            }
            else if (type == 2)
            {
                DictSelected?.Invoke(sender, e);
            }
        }
        #endregion //Event
    }
}
