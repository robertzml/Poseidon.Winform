﻿using System;
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
    /// 编辑分组窗体
    /// </summary>
    public partial class FrmGroupEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentEntity;
        #endregion //Field

        #region Constructor
        public FrmGroupEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentEntity = CallerFactory<IGroupService>.Instance.FindById(id);
        }

        /// <summary>
        /// 初始化窗体
        /// </summary>
        protected override void InitForm()
        {
            this.txtName.Text = this.currentEntity.Name;
            this.txtCode.Text = this.currentEntity.Code;
            this.txtModule.Text = this.currentEntity.Module;
            this.txtRemark.Text = this.currentEntity.Remark;

            this.bsGroup.DataSource = CallerFactory<IGroupService>.Instance.FindAll().ToList();

            this.cmbParent.EditValue = this.currentEntity.ParentId;

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

            if (string.IsNullOrEmpty(this.txtCode.Text.Trim()))
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
        private void SetEntity(Group entity)
        {
            entity.Name = this.txtName.Text;
            entity.Code = this.txtCode.Text;
            entity.Module = this.txtModule.Text;
            entity.Remark = this.txtRemark.Text;
            if (this.cmbParent.EditValue == null)
                entity.ParentId = null;
            else
                entity.ParentId = this.cmbParent.EditValue.ToString();
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
                var entity = CallerFactory<IGroupService>.Instance.FindById(this.currentEntity.Id);
                SetEntity(entity);

                var result = CallerFactory<IGroupService>.Instance.Update(entity);

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
