﻿using System;
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

    /// <summary>
    /// 字典项表格控件
    /// </summary>
    public partial class DictItemGrid : WinEntityGrid<DictItem>
    {
        #region Constructor
        public DictItemGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
