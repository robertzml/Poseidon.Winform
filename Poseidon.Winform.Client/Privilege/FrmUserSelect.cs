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
    /// 用户选择窗体
    /// </summary>
    public partial class FrmUserSelect : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前管理角色
        /// </summary>
        private Role currentRole;
        #endregion //Field

        #region Constructor
        public FrmUserSelect(string roleId)
        {
            InitializeComponent();
            InitData(roleId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string roleId)
        {
            this.currentRole = CallerFactory<IRoleService>.Instance.FindById(roleId);
        }

        protected override void InitForm()
        {
            LoadUsers();
            SetSelectedUsers();
            base.InitForm();
        }

        /// <summary>
        /// 载入用户
        /// </summary>
        private void LoadUsers()
        {
            this.bsUser.DataSource = CallerFactory<IUserService>.Instance.FindAll().ToList();
        }

        /// <summary>
        /// 设置已选择用户
        /// </summary>
        private void SetSelectedUsers()
        {
            for (int i = 0; i < this.bsUser.Count; i++)
            {
                var user = this.bsUser[i] as User;
                if (this.currentRole.Users.Any(r => r == user.Id))
                    this.clbUsers.SetItemChecked(i, true);
            }
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
            List<string> uids = new List<string>();
            var checkedItems = this.clbUsers.CheckedItems;
            foreach (var item in checkedItems)
            {
                var u = item as User;
                uids.Add(u.Id);
            }

            try
            {
                CallerFactory<IRoleService>.Instance.SetUsers(this.currentRole.Id, uids);

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
