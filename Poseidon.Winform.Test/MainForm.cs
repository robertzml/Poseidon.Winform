﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Test
{
    using Poseidon.Winform.Base;
    using Poseidon.Winform.ClientDx;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Event
        private void menuRole_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmRoleManage));
        }
        #endregion //Event

        private void menuMenu_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmMenuManage));
        }

        private void menuPrivilegeMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmPrivilegeManage));
        }
    }
}