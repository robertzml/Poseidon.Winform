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
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 权限管理窗体
    /// </summary>
    public partial class FrmPrivilegeManage : BaseMdiForm
    {
        #region Constructor
        public FrmPrivilegeManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.privilegeTree.RefreshData();
            this.privilegeTree.Expand();

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmPrivilegeAdd));
            this.privilegeTree.RefreshData();
        }

        /// <summary>
        /// 编辑权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = this.privilegeTree.GetCurrentSelectedId();
            if (string.IsNullOrEmpty(id))
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmPrivilegeEdit), new object[] { id });
            this.privilegeTree.RefreshData();
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
