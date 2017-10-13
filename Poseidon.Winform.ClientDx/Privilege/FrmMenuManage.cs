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
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 菜单管理
    /// </summary>
    public partial class FrmMenuManage : BaseMdiForm
    {
        #region Constructor
        public FrmMenuManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.menuTree.Init();
            this.menuTree.Expand();

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmMenuAdd));
            this.menuTree.RefreshData();
        }

        /// <summary>
        /// 编辑菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = this.menuTree.GetCurrentSelectedId();
            if (string.IsNullOrEmpty(id))
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmMenuEdit), new object[] { id });
            this.menuTree.RefreshData();
        }
        #endregion //Event
    }
}
