using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Core
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 分组项表格控件
    /// </summary>
    public partial class GroupItemGrid : WinEntityGrid<GroupItem>
    {
        #region Field

        #endregion //Field

        #region Constructor
        public GroupItemGrid()
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

            var item = this.bsEntity[rowIndex] as GroupItem;
            var org = BusinessFactory<OrganizationBusiness>.Instance.FindById(item.OrganizationId);

            if (e.Column.FieldName == "OrganizationId")
            {
                e.DisplayText = org.Name;
            }
        }

        /// <summary>
        /// 自定义数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var item = this.bsEntity[rowIndex] as GroupItem;
            var org = BusinessFactory<OrganizationBusiness>.Instance.FindById(item.OrganizationId);

            if (e.Column.FieldName == "colRemark" && e.IsGetData)
                e.Value = org.Remark;
        }
        #endregion //Event
    }
}
