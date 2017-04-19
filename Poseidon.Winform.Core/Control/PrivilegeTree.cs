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
    /// 权限树形控件
    /// </summary>
    public partial class PrivilegeTree : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public PrivilegeTree()
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
            this.bsPrivilege.DataSource = CallerFactory<IPrivilegeService>.Instance.FindAll().OrderBy(r => r.Sort);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 刷新数据
        /// </summary>
        public void RefreshData()
        {
            LoadData();
        }

        /// <summary>
        /// 获取当前选中权限ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSelectedId()
        {
            var node = this.tlView.Selection[0];
            if (node == null)
                return null;

            var id = node["Id"].ToString();
            return id;
        }
        #endregion //Method

        #region Delegate
        /// <summary>
        /// 权限选择事件
        /// </summary>
        [Description("权限选择事件")]
        public event EventHandler PrivilegeSelected;
        #endregion //Delegate

        #region Event
        /// <summary>
        /// 节点选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlView_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null)
                return;

            PrivilegeSelected?.Invoke(sender, e);
        }

        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlView_GetNodeDisplayValue(object sender, DevExpress.XtraTreeList.GetNodeDisplayValueEventArgs e)
        {
            var entity = this.tlView.GetDataRecordByNode(e.Node) as Privilege;

            if (e.Column.FieldName == "Action")
            {
                string dis = "";
                if ((entity.Action & (int)DataAction.Create) != 0)
                    dis += "Create|";
                if ((entity.Action & (int)DataAction.Read) != 0)
                    dis += "Read|";
                if ((entity.Action & (int)DataAction.Update) != 0)
                    dis += "Update|";
                if ((entity.Action & (int)DataAction.Delete) != 0)
                    dis += "Delete|";

                if (dis.Length > 0)
                    e.Value = dis.Substring(0, dis.Length - 1);
                else
                    e.Value = "";
            }
        }
        #endregion //Event
    }
}
