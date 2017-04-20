namespace Poseidon.Winform.Core
{
    partial class PrivilegeTree
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
            this.tlView = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSort = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAction = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colStatus = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bsPrivilege = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.tlView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // tlView
            // 
            this.tlView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colSort,
            this.colCode,
            this.colName,
            this.colAction,
            this.colRemark,
            this.colStatus});
            this.tlView.DataSource = this.bsPrivilege;
            this.tlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlView.KeyFieldName = "Id";
            this.tlView.Location = new System.Drawing.Point(0, 0);
            this.tlView.Name = "tlView";
            this.tlView.OptionsBehavior.Editable = false;
            this.tlView.OptionsBehavior.PopulateServiceColumns = true;
            this.tlView.OptionsView.ShowCheckBoxes = true;
            this.tlView.ParentFieldName = "ParentId";
            this.tlView.Size = new System.Drawing.Size(512, 272);
            this.tlView.TabIndex = 0;
            this.tlView.GetNodeDisplayValue += new DevExpress.XtraTreeList.GetNodeDisplayValueEventHandler(this.tlView_GetNodeDisplayValue);
            this.tlView.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlView_FocusedNodeChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 24;
            // 
            // colSort
            // 
            this.colSort.FieldName = "Sort";
            this.colSort.MinWidth = 32;
            this.colSort.Name = "colSort";
            this.colSort.Visible = true;
            this.colSort.VisibleIndex = 0;
            this.colSort.Width = 137;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 137;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 137;
            // 
            // colAction
            // 
            this.colAction.FieldName = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 3;
            this.colAction.Width = 137;
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
            this.colStatus.Width = 24;
            // 
            // bsPrivilege
            // 
            this.bsPrivilege.DataSource = typeof(Poseidon.Core.DL.Privilege);
            // 
            // PrivilegeTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlView);
            this.Name = "PrivilegeTree";
            this.Size = new System.Drawing.Size(512, 272);
            this.Load += new System.EventHandler(this.PrivilegeTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrivilege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlView;
        private System.Windows.Forms.BindingSource bsPrivilege;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSort;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAction;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRemark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colStatus;
    }
}
