using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Client
{
    using DevExpress.XtraEditors.Controls;
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
        private User selectUser;

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
            LoadRoles();
            LoadUsers();

            this.privilegeTree.RefreshData();
            this.privilegeTree.Expand();

            this.userPrivilegeTree.RefreshData();
            this.userPrivilegeTree.Expand();

            base.InitForm();
        }

        /// <summary>
        /// 初始化角色
        /// </summary>
        private void LoadRoles()
        {
            this.bsRole.DataSource = CallerFactory<IRoleService>.Instance.FindAll(false).OrderBy(r => r.Sort);
        }

        /// <summary>
        /// 初始化用户
        /// </summary>
        private void LoadUsers()
        {
            this.bsUser.DataSource = CallerFactory<IUserService>.Instance.FindAll();
        }

        /// <summary>
        /// 初始化用户角色
        /// </summary>
        /// <param name="user"></param>
        private void InitUserRoles(User user)
        {
            var roles = CallerFactory<IRoleService>.Instance.FindUserRoles(user.Id);

            this.cmbUserRoles.Properties.Items.Clear();

            var first = new ImageComboBoxItem();
            first.Description = "用户额外权限";
            first.Value = "";
            this.cmbUserRoles.Properties.Items.Add(first);

            foreach (var item in roles)
            {
                this.cmbUserRoles.Properties.Items.Add(new ImageComboBoxItem
                {
                    Description = item.Name,
                    Value = item.Id
                });
            }
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
                this.selectUser = null;
                return;
            }

            this.selectUser = this.lbUsers.SelectedItem as User;
            this.type = 2;

            this.txtName.Text = this.selectUser.Name;
            this.txtCode.Text = this.selectUser.UserName;
            this.txtRemark.Text = this.selectUser.Remark;

            InitUserRoles(this.selectUser);

            this.privilegeTree.CheckRows(CallerFactory<IUserService>.Instance.GetPrivileges(this.selectUser.Id).ToList());
        }

        /// <summary>
        /// 配置权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (type == 1 && this.currentRole != null)
            {
                ChildFormManage.ShowDialogForm(typeof(FrmPrivilegeSelect), new object[] { type, this.currentRole.Id });
                LoadRoles();
            }
            else if (type == 2 && this.selectUser != null)
            {
                ChildFormManage.ShowDialogForm(typeof(FrmPrivilegeSelect), new object[] { type, this.selectUser.Id });
                LoadUsers();
            }
        }

        /// <summary>
        /// 用户角色选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUserRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbUserRoles.SelectedIndex == -1 || this.selectUser == null)
            {
                return;
            }

            var item = this.cmbUserRoles.SelectedItem as ImageComboBoxItem;
            if (string.IsNullOrEmpty(item.Value.ToString()))
            {
                this.userPrivilegeTree.CheckRows(this.selectUser.Privileges);
            }
            else
            {
                var role = CallerFactory<IRoleService>.Instance.FindById(item.Value.ToString());
                this.userPrivilegeTree.CheckRows(role.Privileges);
            }
        }
        #endregion //Event
    }
}
