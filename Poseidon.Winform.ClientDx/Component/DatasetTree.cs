using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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

    /// <summary>
    /// 数据集树形控件
    /// </summary>
    public partial class DatasetTree : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 是否显示选择框
        /// </summary>
        private bool showCheckBox = false;

        /// <summary>
        /// 是否显示排序码
        /// </summary>

        private bool showSortCode = false;

        /// <summary>
        /// 选择框是否只读
        /// </summary>
        private bool checkBoxReadonly = false;
        #endregion //Field

        #region Constructor
        public DatasetTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入数据
        /// </summary>
        private void LoadData()
        {
            this.bsDataset.DataSource = CallerFactory<IDatasetService>.Instance.FindAll().OrderBy(r => r.Sort);
        }
        #endregion //Function

        #region Method
        public void Init()
        {
            LoadData();
        }
        #endregion //Method

        #region Event
        private void DatasetTree_Load(object sender, EventArgs e)
        {
            this.tlDataset.OptionsView.ShowCheckBoxes = this.showCheckBox;
            this.colSort.Visible = this.showSortCode;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示选择框
        /// </summary>
        [Description("是否显示选择框"), Category("界面"), Browsable(true)]
        public bool ShowCheckBox
        {
            get
            {
                return this.showCheckBox;
            }
            set
            {
                this.showCheckBox = value;
            }
        }

        /// <summary>
        /// 是否显示排序码
        /// </summary>
        [Description("是否显示排序码"), Category("界面"), Browsable(true)]
        public bool ShowSortCode
        {
            get
            {
                return showSortCode;
            }

            set
            {
                showSortCode = value;
            }
        }

        /// <summary>
        /// 选择框是否只读
        /// </summary>
        [Description("选择框是否只读"), Category("功能"), Browsable(true)]
        public bool CheckBoxReadonly
        {
            get
            {
                return checkBoxReadonly;
            }

            set
            {
                checkBoxReadonly = value;
            }
        }
        #endregion //Property
    }
}
