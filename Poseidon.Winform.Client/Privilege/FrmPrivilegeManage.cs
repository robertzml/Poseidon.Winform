using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Client
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 权限管理窗体
    /// </summary>
    public partial class FrmPrivilegeManage : BaseMdiForm
    {
        #region Constructor
        public FrmPrivilegeManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示权限信息
        /// </summary>
        /// <param name="entity"></param>
        private void DisplayInfo(Privilege entity)
        {
            //this.txtName.Text = entity.Name;
            //this.txtCode.Text = entity.Code;
            //this.txtSort.Text = entity.Sort.ToString();
            //this.txtRemark.Text = entity.Remark;

            //this.chkCreate.Checked = Convert.ToBoolean(entity.Action & (int)DataAction.Create);
            //this.chkRead.Checked = Convert.ToBoolean(entity.Action & (int)DataAction.Read);
            //this.chkUpdate.Checked = Convert.ToBoolean(entity.Action & (int)DataAction.Update);
            //this.chkDelete.Checked = Convert.ToBoolean(entity.Action & (int)DataAction.Delete);
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrivilegeManage_Load(object sender, EventArgs e)
        {
            this.privilegeTree.RefreshData();
            this.privilegeTree.Expand();
        }

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmPrivilegeAdd));
            this.privilegeTree.RefreshData();
            this.privilegeTree.Expand();
        }

        /// <summary>
        /// 编辑权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = this.privilegeTree.GetCurrentSelectedId();
            if (string.IsNullOrEmpty(id))
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmPrivilegeEdit), new object[] { id });
            this.privilegeTree.RefreshData();
            this.privilegeTree.Expand();
        }
        #endregion //Event
    }
}
