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

namespace Poseidon.Winform.Core
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Attachment.Caller.Facade;
    using Poseidon.Attachment.Core.DL;
    using Poseidon.Attachment.Core.Utility;

    /// <summary>
    /// 附件预览窗体
    /// </summary>
    public partial class FrmPreview : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 附件
        /// </summary>
        private Attachment attchment;

        /// <summary>
        /// 数据流
        /// </summary>
        private Stream stream;
        #endregion //Field

        #region Constructor
        public FrmPreview(Attachment attchment, Stream stream)
        {
            InitializeComponent();

            this.attchment = attchment;
            this.stream = stream;
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            SetImage(this.stream);

            this.picView.MouseWheel += PicView_MouseWheel;
            base.InitForm();
        }

        /// <summary>
        /// 设置图片
        /// </summary>
        /// <param name="stream">数据流</param>
        private void SetImage(Stream stream)
        {
            try
            {
                var image = Image.FromStream(stream);

                this.picView.Image = image;
                this.picView.Properties.ZoomPercent = 50;
            }
            catch(Exception)
            {
                MessageUtil.ShowWarning("不是图片数据");
            }
        }
        #endregion //Function

        #region Event
        private void imgZoom_EditValueChanged(object sender, EventArgs e)
        {
            picView.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
            picView.Properties.ZoomPercent = imgZoom.Value;
        }

        /// <summary>
        /// 图片缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicView_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                this.imgZoom.Value += 5;
            else if (e.Delta < 0)
                this.imgZoom.Value -= 5;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion //Event
    }
}
