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
    /// 编辑权限窗体
    /// </summary>
    public partial class FrmPrivilegeEdit : BaseSingleForm
    {
        #region Field
        private Privilege currentPrivilege;
        #endregion //Field

        #region Constructor
        public FrmPrivilegeEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentPrivilege = CallerFactory<IPrivilegeService>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            LoadPrivileges();

            this.txtName.Text = this.currentPrivilege.Name;
            this.txtCode.Text = this.currentPrivilege.Code;
            this.luParent.EditValue = this.currentPrivilege.ParentId;
            this.spSort.Value = this.currentPrivilege.Sort;
            this.txtRemark.Text = this.currentPrivilege.Remark;

            this.chkCreate.Checked = Convert.ToBoolean(currentPrivilege.Action & (int)DataAction.Create);
            this.chkRead.Checked = Convert.ToBoolean(currentPrivilege.Action & (int)DataAction.Read);
            this.chkUpdate.Checked = Convert.ToBoolean(currentPrivilege.Action & (int)DataAction.Update);
            this.chkDelete.Checked = Convert.ToBoolean(currentPrivilege.Action & (int)DataAction.Delete);

            base.InitForm();
        }

        /// <summary>
        /// 载入权限
        /// </summary>
        private void LoadPrivileges()
        {
            this.bsPrivilege.DataSource = CallerFactory<IPrivilegeService>.Instance.FindAll();
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
        private void SetEntity(Privilege entity)
        {
            entity.Name = this.txtName.Text;
            entity.Code = this.txtCode.Text;
            if (this.luParent.EditValue == null)
                entity.ParentId = null;
            else
                entity.ParentId = this.luParent.EditValue.ToString();

            entity.Action = Convert.ToInt32(chkCreate.Checked) << 3 | Convert.ToInt32(chkRead.Checked) << 2 |
                Convert.ToInt32(chkUpdate.Checked) << 1 | Convert.ToInt32(chkDelete.Checked);
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

                var entity = CallerFactory<IPrivilegeService>.Instance.FindById(this.currentPrivilege.Id);
                SetEntity(entity);

                var result = CallerFactory<IPrivilegeService>.Instance.Update(entity);

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
