using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Caller.Facade;
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;

    /// <summary>
    /// 菜单树形控件
    /// </summary>
    public partial class MenuTree : UserControl
    {
        #region Constructor
        public MenuTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入数据
        /// </summary>
        private void LoadData()
        {
            this.bsMenu.DataSource = CallerFactory<IMenuService>.Instance.FindAll().OrderBy(r => r.Sort);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            this.LoadData();
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        public void RefreshData()
        {
            this.LoadData();
        }

        /// <summary>
        /// 获取当前选中权限ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSelectedId()
        {
            var node = this.tlMenu.Selection[0];
            if (node == null)
                return null;

            var id = node["Id"].ToString();
            return id;
        }


        /// <summary>
        /// 展开节点
        /// </summary>
        public void Expand()
        {
            this.tlMenu.ExpandAll();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlMenu_GetNodeDisplayValue(object sender, DevExpress.XtraTreeList.GetNodeDisplayValueEventArgs e)
        {
            var entity = this.tlMenu.GetDataRecordByNode(e.Node) as Menu;
            if (entity == null)
                return;

            if (e.Column.FieldName == "Type")
            {
                e.Value = ((MenuType)entity.Type).DisplayName();
            }
        }
        #endregion //Event
    }
}
