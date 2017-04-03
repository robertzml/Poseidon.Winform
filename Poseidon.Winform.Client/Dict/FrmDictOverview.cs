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
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 字典总览
    /// </summary>
    public partial class FrmDictOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前字典分类
        /// </summary>
        private DictCategory currentCategory;

        /// <summary>
        /// 当前字典
        /// </summary>
        private Dict currentDict;
        #endregion //Field

        #region Constructor
        public FrmDictOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 选择分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeDict_CategorySelected(object sender, EventArgs e)
        {
            string id = this.treeDict.GetCurrentSelectCategoryId();
            if (id == null)
                return;

            this.currentCategory = CallerFactory<IDictCategoryService>.Instance.FindById(id);
            this.txtName.Text = this.currentCategory.Name;
            this.txtCode.Text = "";
            this.txtRemark.Text = this.currentCategory.Remark;

            this.dictItemGrid.DataSource = null;
        }

        /// <summary>
        /// 选择字典
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeDict_DictSelected(object sender, EventArgs e)
        {
            string id = this.treeDict.GetCurrentSelectDictId();
            if (id == null)
                return;

            this.currentDict = CallerFactory<IDictService>.Instance.FindById(id);
            this.txtName.Text = this.currentDict.Name;
            this.txtCode.Text = this.currentDict.Code;
            this.txtRemark.Text = this.currentDict.Remark;

            this.dictItemGrid.DataSource = this.currentDict.Items;
        }

        /// <summary>
        /// 添加分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmDictCategoryAdd));
            this.treeDict.Reload();
        }

        /// <summary>
        /// 编辑分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoryEdit_Click(object sender, EventArgs e)
        {
            if (this.currentCategory == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmDictCategoryEdit), new object[] { this.currentCategory.Id });
            this.treeDict.Reload();
        }

        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            if (this.currentCategory == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否确认删除该字典分类") == DialogResult.Yes)
            {
                try
                {
                    CallerFactory<IDictCategoryService>.Instance.Delete(this.currentCategory);
                    this.treeDict.Reload();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }

        /// <summary>
        /// 添加字典
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDictAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmDictAdd));
            this.treeDict.Reload();
        }

        /// <summary>
        /// 编辑字典
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDictEdit_Click(object sender, EventArgs e)
        {
            if (this.currentDict == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmDictEdit), new object[] { this.currentDict.Id });
            this.treeDict.Reload();
        }

        /// <summary>
        /// 删除字典
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDictDelete_Click(object sender, EventArgs e)
        {
            if (this.currentDict == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否确认删除该字典") == DialogResult.Yes)
            {
                try
                {
                    CallerFactory<IDictService>.Instance.Delete(this.currentDict);
                    this.treeDict.Reload();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }
        #endregion //Event
    }
}
