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
    using Poseidon.Winform.Core;

    /// <summary>
    /// 编辑角色窗体
    /// </summary>
    public partial class FrmRoleEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联角色
        /// </summary>
        private Role currentRole;
        #endregion //Field

        #region Constructor
        public FrmRoleEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentRole = CallerFactory<IRoleService>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentRole.Name;
            this.txtCode.Text = this.currentRole.Code;
            this.spSort.Value = this.currentRole.Sort;
            this.txtRemark.Text = this.currentRole.Remark;

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
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (string.IsNullOrEmpty(this.txtCode.Text))
            {
                errorMessage = "代码不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Role entity)
        {
            entity.Name = this.txtName.Text;
            entity.Code = this.txtCode.Text;
            entity.Sort = Convert.ToInt32(this.spSort.Value);
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
            try
            {
                var input = CheckInput();
                if (!input.Item1)
                {
                    MessageUtil.ShowError(input.Item2);
                    return;
                }

                Role entity = CallerFactory<IRoleService>.Instance.FindById(this.currentRole.Id);
                SetEntity(entity);

                var result = CallerFactory<IRoleService>.Instance.Update(entity);

                if (result.success)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                {
                    MessageUtil.ShowInfo("保存失败: " + result.errorMessage);
                }
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
