﻿namespace Poseidon.Winform.Core
{
    partial class MenuTree
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
            this.tlMenu = new DevExpress.XtraTreeList.TreeList();
            this.bsMenu = new System.Windows.Forms.BindingSource();
            this.colAssemblyName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTypeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colGlyph = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLargeGlyph = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPrivilegeCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSort = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tlMenu
            // 
            this.tlMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colName,
            this.colAssemblyName,
            this.colTypeName,
            this.colPrivilegeCode,
            this.colGlyph,
            this.colLargeGlyph,
            this.colType,
            this.colSort,
            this.colParentId,
            this.colRemark});
            this.tlMenu.DataSource = this.bsMenu;
            this.tlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMenu.KeyFieldName = "Id";
            this.tlMenu.Location = new System.Drawing.Point(0, 0);
            this.tlMenu.Name = "tlMenu";
            this.tlMenu.OptionsBehavior.Editable = false;
            this.tlMenu.OptionsBehavior.PopulateServiceColumns = true;
            this.tlMenu.ParentFieldName = "ParentId";
            this.tlMenu.Size = new System.Drawing.Size(495, 388);
            this.tlMenu.TabIndex = 0;
            // 
            // bsMenu
            // 
            this.bsMenu.DataSource = typeof(Poseidon.Core.DL.Menu);
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.FieldName = "AssemblyName";
            this.colAssemblyName.Name = "colAssemblyName";
            this.colAssemblyName.Visible = true;
            this.colAssemblyName.VisibleIndex = 2;
            this.colAssemblyName.Width = 85;
            // 
            // colTypeName
            // 
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 3;
            this.colTypeName.Width = 85;
            // 
            // colGlyph
            // 
            this.colGlyph.FieldName = "Glyph";
            this.colGlyph.Name = "colGlyph";
            this.colGlyph.Visible = true;
            this.colGlyph.VisibleIndex = 5;
            this.colGlyph.Width = 85;
            // 
            // colLargeGlyph
            // 
            this.colLargeGlyph.FieldName = "LargeGlyph";
            this.colLargeGlyph.Name = "colLargeGlyph";
            this.colLargeGlyph.Visible = true;
            this.colLargeGlyph.VisibleIndex = 6;
            this.colLargeGlyph.Width = 86;
            // 
            // colPrivilegeCode
            // 
            this.colPrivilegeCode.FieldName = "PrivilegeCode";
            this.colPrivilegeCode.Name = "colPrivilegeCode";
            this.colPrivilegeCode.Visible = true;
            this.colPrivilegeCode.VisibleIndex = 4;
            this.colPrivilegeCode.Width = 86;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            this.colType.Width = 86;
            // 
            // colSort
            // 
            this.colSort.FieldName = "Sort";
            this.colSort.Name = "colSort";
            this.colSort.Width = 40;
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Width = 40;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 86;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 7;
            this.colRemark.Width = 86;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 40;
            // 
            // MenuTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlMenu);
            this.Name = "MenuTree";
            this.Size = new System.Drawing.Size(495, 388);
            ((System.ComponentModel.ISupportInitialize)(this.tlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAssemblyName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTypeName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPrivilegeCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colGlyph;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLargeGlyph;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSort;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRemark;
        private System.Windows.Forms.BindingSource bsMenu;
    }
}
