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
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 角色管理窗体
    /// </summary>
    public partial class FrmRoleManage : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择角色
        /// </summary>
        private Role currentRole;
        #endregion //Field

        #region Constructor
        public FrmRoleManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadRoles();
            base.InitForm();
        }

        /// <summary>
        /// 载入角色
        /// </summary>
        private void LoadRoles()
        {
            this.bsRole.DataSource = BusinessFactory<RoleBusiness>.Instance.FindAll().OrderBy(r => r.Sort).ToList();
        }

        /// <summary>
        /// 显示角色信息
        /// </summary>
        /// <param name="entity">角色对象</param>
        private void DisplayRoleInfo(Role entity)
        {
            this.txtName.Text = entity.Name;
            this.txtCode.Text = entity.Code;
            this.txtSort.Text = entity.Sort.ToString();
            this.txtRemark.Text = entity.Remark;
            this.txtStatus.Text = ((EntityStatus)entity.Status).DisplayName();
        }

        /// <summary>
        /// 载入相关用户
        /// </summary>
        /// <param name="entity">角色对象</param>
        private void LoadUsers(Role entity)
        {
            var data = BusinessFactory<RoleBusiness>.Instance.FindUsers(entity.Id);
            this.userGrid.DataSource = data.ToList();
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
            if (this.lbRoles.SelectedItem == null)
                return;

            this.currentRole = this.lbRoles.SelectedItem as Role;
            DisplayRoleInfo(this.currentRole);
            LoadUsers(this.currentRole);
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmRoleAdd));
            LoadRoles();
        }

        /// <summary>
        /// 选择用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmUserSelect), new object[] { this.currentRole.Id });
            LoadUsers(this.currentRole);
        }
        #endregion //Event
    }
}
