using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Client
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core;
    using Poseidon.Attachment.Caller.Facade;
    using Poseidon.Attachment.Core.DL;
    using Poseidon.Attachment.Core.Utility;

    /// <summary>
    /// 测试窗体
    /// </summary>
    public partial class TestForm : BaseSingleForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var task = Task.Run(() =>
                {
                    UploadInfo info = new UploadInfo();
                    info.Name = Path.GetFileNameWithoutExtension(dialog.FileName);
                    info.LocalPath = dialog.FileName;
                    info.Remark = "";

                    var att = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi);
                    var result = att.UploadAsync(info);

                    return result;
                });

                var a = await task;
                MessageUtil.ShowInfo(a.Name);
            }
        }
    }
}
