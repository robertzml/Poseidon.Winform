using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Client
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Attachment.Caller.Facade;
    using Poseidon.Attachment.Core;

    /// <summary>
    /// 附件管理窗体
    /// </summary>
    public partial class FrmAttachmentManage : BaseMdiForm
    {
        #region Constructor
        public FrmAttachmentManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            var folders = CallerFactory<IAttachmentService>.GetInstance(CallerType.Win).GetFolders();

            this.lbFolders.DataSource = folders.OrderBy(r => r);
            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 文件夹选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbFolders.SelectedIndex == -1 || this.lbFolders.SelectedItem == null)
            {
                this.attachmentTool.Clear();
                return;
            }

            string folder = this.lbFolders.SelectedItem.ToString();
            this.attachmentTool.Init(folder);
        }
        #endregion //Event
    }
}
