using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    /// 编辑数据集窗体
    /// </summary>
    public partial class FrmDatasetEdit : BaseSingleForm
    {
        #region Field
        private Dataset currentDataset;
        #endregion //Field

        #region Constructor
        public FrmDatasetEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentDataset = CallerFactory<IDatasetService>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            LoadDatasets();

            this.txtName.Text = this.currentDataset.Name;
            this.txtCode.Text = this.currentDataset.Code;
            this.luParent.EditValue = this.currentDataset.ParentId;
            this.spSort.Value = this.currentDataset.Sort;
            this.txtRemark.Text = this.currentDataset.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 载入权限
        /// </summary>
        private void LoadDatasets()
        {
            this.bsDataset.DataSource = CallerFactory<IDatasetService>.Instance.FindAll();
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
        private void SetEntity(Dataset entity)
        {
            entity.Name = this.txtName.Text;
            entity.Code = this.txtCode.Text;
            if (this.luParent.EditValue == null)
                entity.ParentId = null;
            else
                entity.ParentId = this.luParent.EditValue.ToString();

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

                var entity = CallerFactory<IDatasetService>.Instance.FindById(this.currentDataset.Id);
                SetEntity(entity);

                CallerFactory<IDatasetService>.Instance.Update(entity);

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
