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
    using Poseidon.Caller.Facade;
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core;

    /// <summary>
    /// 选择权限窗体
    /// </summary>
    public partial class FrmPrivilegeSelect : BaseSingleForm
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
        /// <summary>
        /// 选择权限
        /// </summary>
        /// <param name="type">类型 1:角色，2:用户</param>
        /// <param name="id">ID</param>
        public FrmPrivilegeSelect(int type, string id)
        {
            InitializeComponent();
            InitData(type, id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(int type, string id)
        {
            this.type = type;
            if (type == 1)
            {
                this.currentRole = CallerFactory<IRoleService>.Instance.FindById(id);
            }
            else
            {
                this.currentUser = CallerFactory<IUserService>.Instance.FindById(id);
            }
        }

        protected override void InitForm()
        {
            this.privilegeTree.RefreshData();
            this.privilegeTree.Expand();

            if (this.type == 1)
            {
                this.txtName.Text = this.currentRole.Name;
                this.txtCode.Text = this.currentRole.Code;

                this.privilegeTree.CheckRows(this.currentRole.Privileges);
            }
            else if (type == 2)
            {
                this.txtName.Text = this.currentUser.Name;
                this.txtCode.Text = this.currentUser.UserName;

                this.privilegeTree.CheckRows(this.currentUser.Privileges);
            }

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.type == 1)
                {
                    var codes = this.privilegeTree.GetCheckedCodes();
                    CallerFactory<IRoleService>.Instance.SetPrivileges(this.currentRole.Id, codes);
                }

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
