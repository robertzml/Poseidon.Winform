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
    using Poseidon.Caller.Facade;
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
            var org = CallerFactory<IOrganizationService>.Instance.FindById(item.OrganizationId);

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
            var org = CallerFactory<IOrganizationService>.Instance.FindById(item.OrganizationId);

            if (e.Column.FieldName == "colRemark" && e.IsGetData)
                e.Value = org.Remark;
        }

        /// <summary>
        /// 导出Excel格式化
        /// </summary>
        /// <param name="e"></param>
        private void GroupItemGrid_ExportToExcelCustomCell(DevExpress.Export.CustomizeCellEventArgs e)
        {
            int rowIndex = e.DataSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count || e.DocumentRow <= 0)
                return;

            var item = this.bsEntity[rowIndex] as GroupItem;
            var org = CallerFactory<IOrganizationService>.Instance.FindById(item.OrganizationId);

            if (e.ColumnFieldName == "OrganizationId")
            {
                e.Value = org.Name;
                e.Handled = true;
            }
        }
        #endregion //Event
    }
}
