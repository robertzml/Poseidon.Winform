using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Core
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Attachment.Caller.Facade;
    using Poseidon.Attachment.Core.DL;

    /// <summary>
    /// 附件工具
    /// </summary>
    public partial class AttachmentTool : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 相关附件
        /// </summary>
        private List<Attachment> attachments;
        #endregion //Field

        #region Constructor
        public AttachmentTool()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 读取附件
        /// </summary>
        /// <param name="id">附件ID</param>
        /// <returns></returns>
        private Stream GetFile(string id)
        {
            var fileStream = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Download(id);
            return fileStream;
        }

        /// <summary>
        /// 预览文件
        /// </summary>
        /// <param name="attachment"></param>
        private void PreviewFile(Attachment attachment)
        {
            this.Cursor = Cursors.WaitCursor;
            var stream = GetFile(attachment.Id);
            this.Cursor = Cursors.Default;

            FrmPreview preview = new FrmPreview(attachment, stream);
            preview.ShowDialog();
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="attachment"></param>
        private void DownloadFile(Attachment attachment)
        {
            this.Cursor = Cursors.WaitCursor;
            var stream = GetFile(attachment.Id);
            this.Cursor = Cursors.Default;

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.RestoreDirectory = true;
            dialog.Filter = "All files(*.*)|*.*";
            dialog.FileName = attachment.OriginName;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = dialog.FileName.ToString();

                // 把 Stream 转换成 byte[]   
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                stream.Seek(0, SeekOrigin.Begin);

                // 把 byte[] 写入文件   
                FileStream fs = new FileStream(localFilePath, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(bytes);
                bw.Close();
                fs.Close();
            }
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="ids"></param>
        public void Init(List<string> ids)
        {
            if (ids != null && ids.Count > 0)
                this.attachments = CallerFactory<IAttachmentService>.GetInstance(CallerType.Win).FindListInIds(ids).ToList();
            else
                this.attachments = new List<Attachment>();
            this.bsAttachment.DataSource = attachments;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 操作按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repActionButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var selected = this.attachmentGridView.GetSelectedRows();
            if (selected.Length == 0)
                return;

            var dsIndex = this.attachmentGridView.GetDataSourceRowIndex(selected[0]);
            var attach = this.bsAttachment[dsIndex] as Attachment;

            try
            {
                if (e.Button.Tag.ToString() == "Preview")
                {
                    PreviewFile(attach);
                }
                else if (e.Button.Tag.ToString() == "Download")
                {
                    DownloadFile(attach);
                }
            }
            catch (PoseidonException pe)
            {
                this.Cursor = Cursors.Default;
                MessageUtil.ShowError(string.Format("错误类型:{0}, 网络状态:{1}", pe.ErrorCode.DisplayName(), pe.HttpStatusCode.ToString()));
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageUtil.ShowError(string.Format("远程访问错误，{0}", ex.InnerException.Message));
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 相关附件
        /// </summary>
        public List<Attachment> Attachments
        {
            get
            {
                return this.attachments;
            }
        }

        /// <summary>
        /// 相关附件ID
        /// </summary>
        public List<string> AttachmentIds
        {
            get
            {
                return this.attachments.Select(r => r.Id).ToList();
            }
        }
        #endregion //Property
    }
}
