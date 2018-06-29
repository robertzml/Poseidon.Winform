using System;
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
        

        private void menuMenu_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmMenuManage));
        }

        private void menuPrivilegeMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmPrivilegeManage));
        }

        private void menuDatasetMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmDatasetManage));
        }

        private void menuPrivilegeAssign_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmPrivilegeAssign));
        }        

        private void menuUser_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmUserList));
        }
        #endregion //Event

        private void menuAttachment_Click(object sender, EventArgs e)
        {
          
        }

        private void menuCache_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmCacheManage));
        }

        private void menuDict_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmDictOverview));
        }

        private void menuModelType_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmModelTypeManage));
        }

        private void menuGroup_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmGroupManage));
        }

        private void menuTest_Click(object sender, EventArgs e)
        {
            
        }
    }
}
