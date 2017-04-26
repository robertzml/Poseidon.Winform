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
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 建筑表格控件
    /// </summary>
    public partial class BuildingGrid : WinEntityGrid<Building>
    {
        #region Field
        /// <summary>
        /// 是否显示复选框
        /// </summary>
        private bool enableMultiSelect = false;
        #endregion //Field

        #region Constructor
        public BuildingGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取选中行
        /// </summary>
        /// <returns></returns>
        public List<Building> GetSelectedRows()
        {
            List<Building> data = new List<Building>();

            int[] rowIndex = this.dgvEntity.GetSelectedRows();

            for (int i = 0; i < rowIndex.Length; i++)
            {
                var row = this.dgvEntity.GetRow(rowIndex[i]) as Building;
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
        private void BuildingGrid_Load(object sender, EventArgs e)
        {
            this.dgvEntity.OptionsSelection.MultiSelect = this.enableMultiSelect;
            if (this.enableMultiSelect)
                this.dgvEntity.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否能多选
        /// </summary>
        [Category("功能"), Description("是否能多选"), Browsable(true)]
        public bool EnableMultiSelect
        {
            get
            {
                return this.enableMultiSelect;
            }
            set
            {
                this.enableMultiSelect = value;
            }
        }
        #endregion //Property
    }
}
