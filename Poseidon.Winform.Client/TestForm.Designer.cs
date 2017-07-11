namespace Poseidon.Winform.Client
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.attachmentTool1 = new Poseidon.Winform.Core.AttachmentTool();
            this.imgAttachTool = new Poseidon.Winform.Core.ImageAttachmentTool();
            this.btnSet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(651, 18);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(542, 18);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.groupControl1);
            this.plFill.Size = new System.Drawing.Size(758, 517);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 517);
            this.plBottom.Size = new System.Drawing.Size(758, 60);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSet);
            this.groupControl1.Controls.Add(this.imgAttachTool);
            this.groupControl1.Controls.Add(this.btnUpload);
            this.groupControl1.Controls.Add(this.attachmentTool1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(758, 446);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(228, 54);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(108, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "上传附件";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // attachmentTool1
            // 
            this.attachmentTool1.Location = new System.Drawing.Point(42, 24);
            this.attachmentTool1.Name = "attachmentTool1";
            this.attachmentTool1.Size = new System.Drawing.Size(165, 189);
            this.attachmentTool1.TabIndex = 0;
            // 
            // imgAttachTool
            // 
            this.imgAttachTool.Location = new System.Drawing.Point(238, 100);
            this.imgAttachTool.Name = "imgAttachTool";
            this.imgAttachTool.Size = new System.Drawing.Size(515, 296);
            this.imgAttachTool.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(388, 54);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "设置附件";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 577);
            this.Name = "TestForm";
            this.Text = "测试窗体";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Core.AttachmentTool attachmentTool1;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private Core.ImageAttachmentTool imgAttachTool;
        private DevExpress.XtraEditors.SimpleButton btnSet;
    }
}