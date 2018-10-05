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
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 用户列表窗体
    /// </summary>
    public partial class FrmUserList : BaseMdiForm
    {
        #region Constructor
        public FrmUserList()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadUsers();
            base.InitForm();
        }

        /// <summary>
        /// 载入用户
        /// </summary>
        private void LoadUsers()
        {
            var data = CallerFactory<IUserService>.Instance.FindAll().ToList();
            this.userGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmUserAdd));
            LoadUsers();
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.userGrid.GetCurrentSelect() == null)
                return;

            var user = this.userGrid.GetCurrentSelect();
            ChildFormManage.ShowDialogForm(typeof(FrmUserEdit), new object[] { user.Id });
            LoadUsers();
        }

        /// <summary>
        /// 启用用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (this.userGrid.GetCurrentSelect() == null)
                return;

            var user = this.userGrid.GetCurrentSelect();
            CallerFactory<IUserService>.Instance.Enable(user.Id);
            LoadUsers();
        }

        /// <summary>
        /// 禁用用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (this.userGrid.GetCurrentSelect() == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否禁用选定用户") == DialogResult.Yes)
            {
                try
                {
                    var user = this.userGrid.GetCurrentSelect();
                    CallerFactory<IUserService>.Instance.Disable(user.Id);
                    LoadUsers();
                }
                catch (Exception pe)
                {
                    MessageUtil.ShowError(string.Format("禁用失败，错误消息:{0}", pe.Message));
                }
            }
        }
        #endregion //Event
    }
}
