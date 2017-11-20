namespace Poseidon.Winform.ClientDx
{
    partial class DatasetTree
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
            this.tlDataset = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAction = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSort = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colStatus = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bsDataset = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tlDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // tlDataset
            // 
            this.tlDataset.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colName,
            this.colCode,
            this.colParentId,
            this.colAction,
            this.colSort,
            this.colRemark,
            this.colStatus});
            this.tlDataset.DataSource = this.bsDataset;
            this.tlDataset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDataset.KeyFieldName = "Id";
            this.tlDataset.Location = new System.Drawing.Point(0, 0);
            this.tlDataset.Name = "tlDataset";
            this.tlDataset.OptionsBehavior.Editable = false;
            this.tlDataset.OptionsBehavior.PopulateServiceColumns = true;
            this.tlDataset.ParentFieldName = "ParentId";
            this.tlDataset.Size = new System.Drawing.Size(561, 419);
            this.tlDataset.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 68;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 137;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 137;
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Width = 68;
            // 
            // colAction
            // 
            this.colAction.FieldName = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 2;
            this.colAction.Width = 137;
            // 
            // colSort
            // 
            this.colSort.FieldName = "Sort";
            this.colSort.Name = "colSort";
            this.colSort.Visible = true;
            this.colSort.VisibleIndex = 3;
            this.colSort.Width = 137;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 4;
            this.colRemark.Width = 137;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 68;
            // 
            // bsDataset
            // 
            this.bsDataset.DataSource = typeof(Poseidon.Core.DL.Dataset);
            // 
            // DatasetTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlDataset);
            this.Name = "DatasetTree";
            this.Size = new System.Drawing.Size(561, 419);
            this.Load += new System.EventHandler(this.DatasetTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlDataset;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAction;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSort;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRemark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colStatus;
        private System.Windows.Forms.BindingSource bsDataset;
    }
}
