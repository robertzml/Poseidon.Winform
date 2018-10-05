using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Core
{
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 设施表格控件
    /// </summary>
    public partial class FacilityGrid : WinEntityGrid<Facility>
    {
        #region Field
        /// <summary>
        /// 是否显示复选框
        /// </summary>
        private bool enableMultiCheckSelect = false;
        #endregion //Field

        #region Constructor
        public FacilityGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取选中行
        /// </summary>
        /// <returns></returns>
        public List<Facility> GetSelectedRows()
        {
            List<Facility> data = new List<Facility>();

            int[] rowIndex = this.dgvEntity.GetSelectedRows();

            for (int i = 0; i < rowIndex.Length; i++)
            {
                var row = this.dgvEntity.GetRow(rowIndex[i]) as Facility;
                data.Add(row);
            }

            return data;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FacilityGrid_Load(object sender, EventArgs e)
        {
            this.dgvEntity.OptionsSelection.MultiSelect = this.enableMultiCheckSelect;
            if (this.enableMultiCheckSelect)
                this.dgvEntity.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否能多选
        /// </summary>
        [Category("功能"), Description("是否能多选"), Browsable(true)]
        public bool EnableMultiCheckSelect
        {
            get
            {
                return this.enableMultiCheckSelect;
            }
            set
            {
                this.enableMultiCheckSelect = value;
            }
        }
        #endregion //Property
    }
}
