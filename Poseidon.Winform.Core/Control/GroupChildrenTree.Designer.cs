namespace Poseidon.Winform.Core
{
    partial class GroupChildrenTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupChildrenTree));
            this.tlGroup = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // tlGroup
            // 
            this.tlGroup.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.tlGroup.Appearance.FocusedCell.Options.UseBackColor = true;
            this.tlGroup.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colName,
            this.colType});
            this.tlGroup.DataSource = null;
            this.tlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlGroup.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlGroup.Location = new System.Drawing.Point(0, 0);
            this.tlGroup.Name = "tlGroup";
            this.tlGroup.OptionsBehavior.Editable = false;
            this.tlGroup.Size = new System.Drawing.Size(239, 344);
            this.tlGroup.StateImageList = this.imageCollection;
            this.tlGroup.TabIndex = 0;
            this.tlGroup.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.tlGroup_BeforeExpand);
            this.tlGroup.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlGroup_FocusedNodeChanged);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "colId";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "colName";
            this.colName.MinWidth = 33;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 221;
            // 
            // colType
            // 
            this.colType.Caption = "类型";
            this.colType.FieldName = "colType";
            this.colType.Name = "colType";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::Poseidon.Winform.Core.Properties.Resources.DocumentMap_16x16, "DocumentMap_16x16", typeof(global::Poseidon.Winform.Core.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "DocumentMap_16x16");
            this.imageCollection.InsertImage(global::Poseidon.Winform.Core.Properties.Resources.BONote_16x16, "BONote_16x16", typeof(global::Poseidon.Winform.Core.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "BONote_16x16");
            // 
            // GroupChildrenTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlGroup);
            this.Name = "GroupChildrenTree";
            this.Size = new System.Drawing.Size(239, 344);
            this.Load += new System.EventHandler(this.GroupChildrenTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlGroup;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
