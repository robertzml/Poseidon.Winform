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
    /// 权限分配窗体
    /// </summary>
    public partial class FrmPrivilegeAssign : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 类型 1:角色 2:用户
        /// </summary>
        private int type;

        /// <summary>
        /// 当前关联用户
        /// </summary>
        private User currentUser;

        /// <summary>
        /// 当前关联角色
        /// </summary>
        private Role currentRole;
        #endregion //Field

        #region Constructor
        public FrmPrivilegeAssign()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.bsRole.DataSource = CallerFactory<IRoleService>.Instance.FindAll().OrderBy(r => r.Sort);
            this.bsUser.DataSource = CallerFactory<IUserService>.Instance.FindAll();

            this.privilegeTree.RefreshData();
            this.privilegeTree.Expand();

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbRoles.SelectedIndex == -1)
            {
                this.currentRole = null;
                return;
            }

            this.currentRole = this.lbRoles.SelectedItem as Role;
            this.type = 1;

            this.txtName.Text = this.currentRole.Name;
            this.txtCode.Text = this.currentRole.Code;
            this.txtRemark.Text = this.currentRole.Remark;

            this.privilegeTree.CheckRows(this.currentRole.Privileges);
        }

        /// <summary>
        /// 选择用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbUsers.SelectedIndex == -1)
            {
                this.currentUser = null;
                return;
            }

            this.currentUser = this.lbUsers.SelectedItem as User;
            this.type = 2;

            this.txtName.Text = this.currentUser.Name;
            this.txtCode.Text = this.currentUser.UserName;
            this.txtRemark.Text = this.currentUser.Remark;
        }

        /// <summary>
        /// 选择权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (type == 1 && this.currentRole != null)
            {
                ChildFormManage.ShowDialogForm(typeof(FrmPrivilegeSelect), new object[] { type, this.currentRole.Id });
            }
            else if (type == 2 && this.currentUser != null)
            {
                ChildFormManage.ShowDialogForm(typeof(FrmPrivilegeSelect), new object[] { type, this.currentUser.Id });
            }
        }
        #endregion //Event
    }
}
