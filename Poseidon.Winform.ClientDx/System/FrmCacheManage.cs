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
    using Poseidon.Core.DL;
    using Poseidon.Common;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 缓存管理
    /// </summary>
    public partial class FrmCacheManage : BaseMdiForm
    {
        #region Constructor
        public FrmCacheManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入缓存数据
        /// </summary>
        private void LoadCaches()
        {
            var keys = Cache.Instance.GetKeys();

            DataTable dt = new DataTable();
            var col1 = dt.Columns.Add();
            col1.Caption = "键";
            col1.ColumnName = "colKey";

            var col2 = dt.Columns.Add();
            col2.Caption = "值";
            col2.ColumnName = "colValue";

            foreach (var key in keys)
            {
                DataRow row = dt.NewRow();
                row[0] = key;
                row[1] = Cache.Instance[key];

                dt.Rows.Add(row);
            }

            this.dgcCache.DataSource = dt;
        }

        protected override void InitForm()
        {
            LoadCaches();
            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCaches();
        }
        #endregion //Event
    }
}
