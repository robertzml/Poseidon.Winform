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
    /// 编辑字典窗体
    /// </summary>
    public partial class FrmDictEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联字典
        /// </summary>
        private Dict currentDict;
        #endregion //Field

        #region Constructor
        public FrmDictEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentDict = CallerFactory<IDictService>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.bsCategory.DataSource = CallerFactory<IDictCategoryService>.Instance.FindAll();

            this.txtName.Text = this.currentDict.Name;
            this.txtCode.Text = this.currentDict.Code;
            this.luCategory.EditValue = this.currentDict.CategoryId;
            this.txtRemark.Text = this.currentDict.Remark;
            this.itemGrid.DataSource = this.currentDict.Items;

            base.InitForm();
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Dict entity)
        {
            entity.Name = this.txtName.Text;
            entity.Code = this.txtCode.Text;
            entity.CategoryId = this.luCategory.EditValue.ToString();
            entity.Items = this.itemGrid.DataSource;
            entity.Remark = this.txtRemark.Text;

            foreach (var item in entity.Items)
            {
                item.Remark = item.Remark ?? "";
            }
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

            if (this.luCategory.EditValue == null)
            {
                errorMessage = "请选择分类";
                return new Tuple<bool, string>(false, errorMessage);
            }

            foreach (var item in this.itemGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.Value))
                {
                    errorMessage = "字典值不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            return new Tuple<bool, string>(true, "");
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
            this.itemGrid.CloseEditor();

            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                var entity = CallerFactory<IDictService>.Instance.FindById(this.currentDict.Id);

                SetEntity(entity);

                var result = CallerFactory<IDictService>.Instance.Update(entity);

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
