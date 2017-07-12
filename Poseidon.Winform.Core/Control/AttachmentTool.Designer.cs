namespace Poseidon.Winform.Core
{
    partial class AttachmentTool
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachmentTool));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dgcAttachment = new DevExpress.XtraGrid.GridControl();
            this.bsAttachment = new System.Windows.Forms.BindingSource(this.components);
            this.attachmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploadTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMD5Hash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repActionButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repActionButton)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcAttachment
            // 
            this.dgcAttachment.DataSource = this.bsAttachment;
            this.dgcAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcAttachment.Location = new System.Drawing.Point(0, 0);
            this.dgcAttachment.MainView = this.attachmentGridView;
            this.dgcAttachment.Name = "dgcAttachment";
            this.dgcAttachment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repActionButton});
            this.dgcAttachment.Size = new System.Drawing.Size(699, 440);
            this.dgcAttachment.TabIndex = 0;
            this.dgcAttachment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.attachmentGridView});
            // 
            // bsAttachment
            // 
            this.bsAttachment.DataSource = typeof(Poseidon.Attachment.Core.DL.Attachment);
            // 
            // attachmentGridView
            // 
            this.attachmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colFileName,
            this.colOriginName,
            this.colExtension,
            this.colContentType,
            this.colMBSize,
            this.colSize,
            this.colUploadTime,
            this.colMD5Hash,
            this.colRemark,
            this.colAction});
            this.attachmentGridView.GridControl = this.dgcAttachment;
            this.attachmentGridView.Name = "attachmentGridView";
            this.attachmentGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentGridView.OptionsCustomization.AllowGroup = false;
            this.attachmentGridView.OptionsMenu.EnableGroupPanelMenu = false;
            this.attachmentGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.attachmentGridView.OptionsView.EnableAppearanceOddRow = true;
            this.attachmentGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.attachmentGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 85;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.OptionsColumn.AllowEdit = false;
            // 
            // colOriginName
            // 
            this.colOriginName.FieldName = "OriginName";
            this.colOriginName.Name = "colOriginName";
            this.colOriginName.OptionsColumn.AllowEdit = false;
            this.colOriginName.Visible = true;
            this.colOriginName.VisibleIndex = 1;
            this.colOriginName.Width = 85;
            // 
            // colExtension
            // 
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.OptionsColumn.AllowEdit = false;
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 2;
            this.colExtension.Width = 85;
            // 
            // colContentType
            // 
            this.colContentType.FieldName = "ContentType";
            this.colContentType.Name = "colContentType";
            this.colContentType.OptionsColumn.AllowEdit = false;
            this.colContentType.Visible = true;
            this.colContentType.VisibleIndex = 3;
            this.colContentType.Width = 85;
            // 
            // colMBSize
            // 
            this.colMBSize.Caption = "文件大小(MB)";
            this.colMBSize.FieldName = "colMBSize";
            this.colMBSize.Name = "colMBSize";
            this.colMBSize.OptionsColumn.AllowEdit = false;
            this.colMBSize.UnboundExpression = "Round(ToDecimal([Size]) / 1024 / 1024, 2)";
            this.colMBSize.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colMBSize.Visible = true;
            this.colMBSize.VisibleIndex = 4;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.OptionsColumn.AllowEdit = false;
            this.colSize.Width = 85;
            // 
            // colUploadTime
            // 
            this.colUploadTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colUploadTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUploadTime.FieldName = "UploadTime";
            this.colUploadTime.Name = "colUploadTime";
            this.colUploadTime.OptionsColumn.AllowEdit = false;
            this.colUploadTime.Visible = true;
            this.colUploadTime.VisibleIndex = 5;
            this.colUploadTime.Width = 99;
            // 
            // colMD5Hash
            // 
            this.colMD5Hash.FieldName = "MD5Hash";
            this.colMD5Hash.Name = "colMD5Hash";
            this.colMD5Hash.OptionsColumn.AllowEdit = false;
            this.colMD5Hash.Visible = true;
            this.colMD5Hash.VisibleIndex = 6;
            this.colMD5Hash.Width = 77;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.AllowEdit = false;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 7;
            this.colRemark.Width = 80;
            // 
            // colAction
            // 
            this.colAction.Caption = "操作";
            this.colAction.ColumnEdit = this.repActionButton;
            this.colAction.Name = "colAction";
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 8;
            // 
            // repActionButton
            // 
            this.repActionButton.AutoHeight = false;
            serializableAppearanceObject3.Options.UseTextOptions = true;
            serializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            serializableAppearanceObject4.Options.UseTextOptions = true;
            serializableAppearanceObject4.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repActionButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "预览", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repActionButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "Preview", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "下载", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repActionButton.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", "Download", null, true)});
            this.repActionButton.Name = "repActionButton";
            this.repActionButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repActionButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repActionButton_ButtonClick);
            // 
            // AttachmentTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgcAttachment);
            this.Name = "AttachmentTool";
            this.Size = new System.Drawing.Size(699, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dgcAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repActionButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcAttachment;
        private DevExpress.XtraGrid.Views.Grid.GridView attachmentGridView;
        private System.Windows.Forms.BindingSource bsAttachment;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginName;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colContentType;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colUploadTime;
        private DevExpress.XtraGrid.Columns.GridColumn colMD5Hash;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMBSize;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repActionButton;
    }
}
