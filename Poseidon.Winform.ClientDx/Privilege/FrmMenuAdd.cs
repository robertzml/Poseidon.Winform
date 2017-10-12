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
    /// 添加菜单窗体
    /// </summary>
    public partial class FrmMenuAdd : BaseSingleForm
    {
        #region Constructor
        public FrmMenuAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadMenus();
            base.InitForm();
        }

        /// <summary>
        /// 载入菜单
        /// </summary>
        private void LoadMenus()
        {
            this.bsMenu.DataSource = CallerFactory<IMenuService>.Instance.FindAll();
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

            if (string.IsNullOrEmpty(this.txtAssemblyName.Text))
            {
                errorMessage = "程序集名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (string.IsNullOrEmpty(this.txtTypeName.Text))
            {
                errorMessage = "类型名称不能为空";
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
            if (this.tluParent.EditValue == null)
                entity.ParentId = null;
            else
                entity.ParentId = this.tluParent.EditValue.ToString();

            entity.Sort = Convert.ToInt32(this.spSort.Value);
            entity.Remark = this.txtRemark.Text;
        }
        #endregion //Function
    }
}
