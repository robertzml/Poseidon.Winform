using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Winform.ClientDx
{
    using Poseidon.Base.System;
    using Poseidon.Core.DL;
    using Poseidon.Common;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 模型类型列表控件
    /// </summary>
    public partial class ModelTypeGrid : WinEntityGrid<ModelType>
    {
        #region Constructor
        public ModelTypeGrid()
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

            var item = this.bsEntity[rowIndex] as ModelType;

            if (e.Column.FieldName == "Category")
            {
                e.DisplayText = ((ModelCategory)e.Value).DisplayName();
            }
        }
        #endregion //Event
    }
}
