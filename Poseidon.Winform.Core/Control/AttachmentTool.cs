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
    using Poseidon.Winform.Base;
    using Poseidon.Attachment.Core.DL;

    /// <summary>
    /// 附件管理工具
    /// </summary>
    public partial class AttachmentTool : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 附件列表
        /// </summary>
        private List<Attachment> attachments = new List<Attachment>();
        #endregion //Field

        #region Constructor
        public AttachmentTool()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        private void InitControl()
        {
            this.bsAttachment.DataSource = attachments;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="ids"></param>
        public void Init(List<string> ids)
        {

        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttachmentTool_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        /// <summary>
        /// 新增附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUpload upload = new FrmUpload();
            if (upload.ShowDialog() == DialogResult.OK)
            {
                this.attachments.Add(upload.Attachment);
            }
        }
        #endregion //Event
    }
}
