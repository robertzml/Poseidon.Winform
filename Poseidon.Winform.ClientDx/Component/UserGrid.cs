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
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Base.System;
    using Poseidon.Common;

    /// <summary>
    /// 用户表格控件
    /// </summary>
    public partial class UserGrid : WinEntityGrid<User>
    {
        #region Constructor
        public UserGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var item = this.bsEntity[rowIndex] as User;

            if (e.Column.FieldName == "Status")
            {
                e.DisplayText = ((EntityStatus)item.Status).DisplayName();
            }
        }
        #endregion //Event
    }
}
