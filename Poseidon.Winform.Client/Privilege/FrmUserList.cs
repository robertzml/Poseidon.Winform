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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 用户列表窗体
    /// </summary>
    public partial class FrmUserList : BaseMdiForm
    {
        #region Constructor
        public FrmUserList()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadUsers();
            base.InitForm();
        }

        /// <summary>
        /// 载入用户
        /// </summary>
        private void LoadUsers()
        {
            var data = BusinessFactory<UserBusiness>.Instance.FindAll().ToList();
            this.userGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmUserAdd));
            LoadUsers();
        }
        #endregion //Event
    }
}
