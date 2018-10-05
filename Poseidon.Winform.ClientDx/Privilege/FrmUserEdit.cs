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
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 编辑用户窗体
    /// </summary>
    public partial class FrmUserEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前用户
        /// </summary>
        private User user;
        #endregion //Field

        #region Constructor
        public FrmUserEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.user = CallerFactory<IUserService>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtUserName.Text = this.user.UserName;
            this.txtName.Text = this.user.Name;
            this.txtRemark.Text = this.user.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "姓名不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (this.txtPassword.Text != this.txtConfirmPassword.Text)
            {
                errorMessage = "两次输入密码不一致";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(User entity)
        {
            entity.Name = this.txtName.Text;
            if (!string.IsNullOrEmpty(this.txtPassword.Text))
                entity.Password = Hasher.SHA1Encrypt(this.txtPassword.Text);
            entity.Remark = this.txtRemark.Text;
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
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                User entity = CallerFactory<IUserService>.Instance.FindById(this.user.Id);
                SetEntity(entity);

                CallerFactory<IUserService>.Instance.Update(entity);

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
