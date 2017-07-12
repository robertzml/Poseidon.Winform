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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachmentTool));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dgcAttachment = new DevExpress.XtraGrid.GridControl();
            this.bsAttachment = new System.Windows.Forms.BindingSource();
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
            this.repoCardButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.attachmentCardView = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContentType2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploadTime2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMd5Hash2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCardView = new DevExpress.XtraEditors.CheckButton();
            this.btnGridView = new DevExpress.XtraEditors.CheckButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgcAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repActionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentCardView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcAttachment
            // 
            this.dgcAttachment.DataSource = this.bsAttachment;
            this.dgcAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcAttachment.Location = new System.Drawing.Point(3, 3);
            this.dgcAttachment.MainView = this.attachmentGridView;
            this.dgcAttachment.Name = "dgcAttachment";
            this.dgcAttachment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repActionButton,
            this.repoCardButton});
            this.dgcAttachment.Size = new System.Drawing.Size(693, 394);
            this.dgcAttachment.TabIndex = 0;
            this.dgcAttachment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.attachmentGridView,
            this.attachmentCardView});
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
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            serializableAppearanceObject2.Options.UseTextOptions = true;
            serializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repActionButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "预览", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repActionButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Preview", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "下载", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repActionButton.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "Download", null, true)});
            this.repActionButton.Name = "repActionButton";
            this.repActionButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repActionButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repActionButton_ButtonClick);
            // 
            // repoCardButton
            // 
            this.repoCardButton.AutoHeight = false;
            this.repoCardButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "预览", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repoCardButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "Preview", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repoCardButton.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", "Download", null, true)});
            this.repoCardButton.Name = "repoCardButton";
            this.repoCardButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoCardButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoCardButton_ButtonClick);
            // 
            // attachmentCardView
            // 
            this.attachmentCardView.CardCaptionFormat = "附件";
            this.attachmentCardView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName2,
            this.colOriginName2,
            this.colExtension2,
            this.colContentType2,
            this.gridColumn1,
            this.colSize2,
            this.colUploadTime2,
            this.colMd5Hash2,
            this.colRemark2,
            this.gridColumn2});
            this.attachmentCardView.FocusedCardTopFieldIndex = 0;
            this.attachmentCardView.GridControl = this.dgcAttachment;
            this.attachmentCardView.Name = "attachmentCardView";
            this.attachmentCardView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentCardView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentCardView.OptionsView.ShowCardExpandButton = false;
            // 
            // colName2
            // 
            this.colName2.Caption = "名称";
            this.colName2.FieldName = "Name";
            this.colName2.Name = "colName2";
            this.colName2.OptionsColumn.AllowEdit = false;
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 0;
            // 
            // colOriginName2
            // 
            this.colOriginName2.Caption = "原始文件名";
            this.colOriginName2.FieldName = "OriginName";
            this.colOriginName2.Name = "colOriginName2";
            this.colOriginName2.OptionsColumn.AllowEdit = false;
            this.colOriginName2.Visible = true;
            this.colOriginName2.VisibleIndex = 2;
            // 
            // colExtension2
            // 
            this.colExtension2.Caption = "扩展名";
            this.colExtension2.FieldName = "Extension";
            this.colExtension2.Name = "colExtension2";
            this.colExtension2.OptionsColumn.AllowEdit = false;
            this.colExtension2.Visible = true;
            this.colExtension2.VisibleIndex = 1;
            // 
            // colContentType2
            // 
            this.colContentType2.Caption = "文件类型";
            this.colContentType2.FieldName = "ContentType";
            this.colContentType2.Name = "colContentType2";
            this.colContentType2.OptionsColumn.AllowEdit = false;
            this.colContentType2.Visible = true;
            this.colContentType2.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "文件大小(MB)";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundExpression = "Round(ToDecimal([Size]) / 1024 / 1024, 2)";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // colSize2
            // 
            this.colSize2.Caption = "文件大小";
            this.colSize2.FieldName = "Size";
            this.colSize2.Name = "colSize2";
            this.colSize2.OptionsColumn.AllowEdit = false;
            // 
            // colUploadTime2
            // 
            this.colUploadTime2.Caption = "上传时间";
            this.colUploadTime2.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colUploadTime2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUploadTime2.FieldName = "UploadTime";
            this.colUploadTime2.Name = "colUploadTime2";
            this.colUploadTime2.OptionsColumn.AllowEdit = false;
            this.colUploadTime2.Visible = true;
            this.colUploadTime2.VisibleIndex = 5;
            // 
            // colMd5Hash2
            // 
            this.colMd5Hash2.Caption = "文件Hash";
            this.colMd5Hash2.FieldName = "MD5Hash";
            this.colMd5Hash2.Name = "colMd5Hash2";
            this.colMd5Hash2.OptionsColumn.AllowEdit = false;
            this.colMd5Hash2.Visible = true;
            this.colMd5Hash2.VisibleIndex = 6;
            // 
            // colRemark2
            // 
            this.colRemark2.Caption = "备注";
            this.colRemark2.FieldName = "Remark";
            this.colRemark2.Name = "colRemark2";
            this.colRemark2.OptionsColumn.AllowEdit = false;
            this.colRemark2.OptionsFilter.AllowFilter = false;
            this.colRemark2.Visible = true;
            this.colRemark2.VisibleIndex = 7;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "操作";
            this.gridColumn2.ColumnEdit = this.repoCardButton;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCardView);
            this.panelControl1.Controls.Add(this.btnGridView);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 403);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(693, 34);
            this.panelControl1.TabIndex = 1;
            // 
            // btnCardView
            // 
            this.btnCardView.Location = new System.Drawing.Point(154, 2);
            this.btnCardView.Name = "btnCardView";
            this.btnCardView.Size = new System.Drawing.Size(132, 30);
            this.btnCardView.TabIndex = 1;
            this.btnCardView.Tag = "CardView";
            this.btnCardView.Text = "卡牌视图";
            this.btnCardView.CheckedChanged += new System.EventHandler(this.btnSelectView_CheckedChanged);
            // 
            // btnGridView
            // 
            this.btnGridView.Checked = true;
            this.btnGridView.Location = new System.Drawing.Point(5, 2);
            this.btnGridView.Name = "btnGridView";
            this.btnGridView.Size = new System.Drawing.Size(132, 30);
            this.btnGridView.TabIndex = 0;
            this.btnGridView.Tag = "GridView";
            this.btnGridView.Text = "表格视图";
            this.btnGridView.CheckedChanged += new System.EventHandler(this.btnSelectView_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgcAttachment, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 440);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AttachmentTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AttachmentTool";
            this.Size = new System.Drawing.Size(699, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dgcAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repActionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentCardView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.Views.Card.CardView attachmentCardView;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckButton btnCardView;
        private DevExpress.XtraEditors.CheckButton btnGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginName2;
        private DevExpress.XtraGrid.Columns.GridColumn colContentType2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colSize2;
        private DevExpress.XtraGrid.Columns.GridColumn colUploadTime2;
        private DevExpress.XtraGrid.Columns.GridColumn colMd5Hash2;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoCardButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
