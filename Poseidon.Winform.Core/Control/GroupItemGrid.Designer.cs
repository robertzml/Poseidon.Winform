namespace Poseidon.Winform.Core
{
    partial class GroupItemGrid
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
            this.colOrganizationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Core.DL.GroupItem);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSort,
            this.colGroupCode,
            this.colOrganizationId,
            this.colModelType,
            this.colRemark});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            this.dgvEntity.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.dgvEntity_CustomUnboundColumnData);
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colOrganizationId
            // 
            this.colOrganizationId.Caption = "组织名称";
            this.colOrganizationId.FieldName = "OrganizationId";
            this.colOrganizationId.Name = "colOrganizationId";
            this.colOrganizationId.OptionsColumn.AllowEdit = false;
            this.colOrganizationId.Visible = true;
            this.colOrganizationId.VisibleIndex = 2;
            // 
            // colModelType
            // 
            this.colModelType.Caption = "组织模型类型";
            this.colModelType.FieldName = "ModelType";
            this.colModelType.Name = "colModelType";
            this.colModelType.OptionsColumn.AllowEdit = false;
            this.colModelType.Visible = true;
            this.colModelType.VisibleIndex = 3;
            // 
            // colSort
            // 
            this.colSort.Caption = "排序码";
            this.colSort.FieldName = "Sort";
            this.colSort.Name = "colSort";
            this.colSort.Visible = true;
            this.colSort.VisibleIndex = 0;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "colRemark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.AllowEdit = false;
            this.colRemark.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 4;
            // 
            // colGroupCode
            // 
            this.colGroupCode.Caption = "分组代码";
            this.colGroupCode.FieldName = "GroupCode";
            this.colGroupCode.Name = "colGroupCode";
            this.colGroupCode.OptionsColumn.AllowEdit = false;
            this.colGroupCode.Visible = true;
            this.colGroupCode.VisibleIndex = 1;
            // 
            // GroupItemGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GroupItemGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colOrganizationId;
        private DevExpress.XtraGrid.Columns.GridColumn colModelType;
        private DevExpress.XtraGrid.Columns.GridColumn colSort;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupCode;
    }
}
