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
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
 
    /// <summary>
    /// 编辑菜单窗体
    /// </summary>
    public partial class FrmMenuEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前菜单
        /// </summary>
        private Menu currentMenu;
        #endregion //Field

        #region Constructor
        public FrmMenuEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentMenu = CallerFactory<IMenuService>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            LoadMenus();

            this.cmbType.Properties.Items.AddEnum(typeof(MenuType));

            this.txtName.Text = this.currentMenu.Name;
            this.txtAssemblyName.Text = this.currentMenu.AssemblyName;
            this.txtTypeName.Text = this.currentMenu.TypeName;
            this.txtPrivilegeCode.Text = this.currentMenu.PrivilegeCode;
            this.cmbType.EditValue = (MenuType)this.currentMenu.Type;
            this.tluParent.EditValue = this.currentMenu.ParentId;

            this.bteGlyph.Text = this.currentMenu.Glyph;
            this.bteLargeGlyph.Text = this.currentMenu.LargeGlyph;
            this.chkVisible.Checked = this.currentMenu.Visible;
            this.spSort.Value = this.currentMenu.Sort;
            this.txtRemark.Text = this.currentMenu.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 载入菜单
        /// </summary>
        private void LoadMenus()
        {
            this.bsMenu.DataSource = CallerFactory<IMenuService>.Instance.FindAll().OrderBy(r => r.Sort);
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

            if (string.IsNullOrEmpty(this.txtPrivilegeCode.Text))
            {
                errorMessage = "权限代码不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (this.cmbType.EditValue == null)
            {
                errorMessage = "类型不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Menu entity)
        {
            entity.Name = this.txtName.Text;
            entity.AssemblyName = this.txtAssemblyName.Text;
            entity.TypeName = this.txtTypeName.Text;
            entity.PrivilegeCode = this.txtPrivilegeCode.Text;
            entity.Type = Convert.ToInt32(this.cmbType.EditValue);

            if (this.tluParent.EditValue == null)
                entity.ParentId = null;
            else
                entity.ParentId = this.tluParent.EditValue.ToString();

            entity.Glyph = this.bteGlyph.Text;
            entity.LargeGlyph = this.bteLargeGlyph.Text;

            entity.Visible = this.chkVisible.Checked;
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

                var entity = CallerFactory<IMenuService>.Instance.FindById(this.currentMenu.Id);
                SetEntity(entity);

                var result = CallerFactory<IMenuService>.Instance.Update(entity);

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
