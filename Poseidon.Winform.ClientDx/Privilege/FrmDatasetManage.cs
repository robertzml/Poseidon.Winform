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
    /// 数据集管理窗体
    /// </summary>
    public partial class FrmDatasetManage : BaseMdiForm
    {
        #region Constructor
        public FrmDatasetManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.dsTree.Init();
            this.dsTree.Expand();

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加数据集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmDatasetAdd));
            this.dsTree.RefreshData();
        }
        
        /// <summary>
        /// 编辑数据集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = this.dsTree.GetCurrentSelectedId();
            if (string.IsNullOrEmpty(id))
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmDatasetEdit), new object[] { id });
            this.dsTree.RefreshData();
        }
        #endregion //Event
    }
}
