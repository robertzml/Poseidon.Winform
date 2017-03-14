﻿namespace Poseidon.Winform.Client
{
    partial class FrmDictOverview
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeDict = new Poseidon.Winform.Core.DictTree();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.btnDictDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnDictEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDictAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCategoryDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCategoryEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnCategoryAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dictItemGrid = new Poseidon.Winform.Core.DictItemGrid();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeDict);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(194, 486);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "字典列表";
            // 
            // treeDict
            // 
            this.treeDict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDict.Location = new System.Drawing.Point(2, 21);
            this.treeDict.Name = "treeDict";
            this.treeDict.Size = new System.Drawing.Size(190, 463);
            this.treeDict.TabIndex = 0;
            this.treeDict.DictSelected += new System.EventHandler(this.treeDict_DictSelected);
            this.treeDict.CategorySelected += new System.EventHandler(this.treeDict_CategorySelected);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(560, 194);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "操作";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Controls.Add(this.btnDictDelete);
            this.layoutControl1.Controls.Add(this.btnDictEdit);
            this.layoutControl1.Controls.Add(this.btnDictAdd);
            this.layoutControl1.Controls.Add(this.btnCategoryDelete);
            this.layoutControl1.Controls.Add(this.btnCategoryEdit);
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.btnCategoryAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(556, 171);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(39, 36);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(505, 20);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 12;
            // 
            // btnDictDelete
            // 
            this.btnDictDelete.Location = new System.Drawing.Point(375, 137);
            this.btnDictDelete.Name = "btnDictDelete";
            this.btnDictDelete.Size = new System.Drawing.Size(169, 22);
            this.btnDictDelete.StyleController = this.layoutControl1;
            this.btnDictDelete.TabIndex = 11;
            this.btnDictDelete.Text = "删除字典";
            // 
            // btnDictEdit
            // 
            this.btnDictEdit.Location = new System.Drawing.Point(203, 137);
            this.btnDictEdit.Name = "btnDictEdit";
            this.btnDictEdit.Size = new System.Drawing.Size(168, 22);
            this.btnDictEdit.StyleController = this.layoutControl1;
            this.btnDictEdit.TabIndex = 10;
            this.btnDictEdit.Text = "编辑字典";
            this.btnDictEdit.Click += new System.EventHandler(this.btnDictEdit_Click);
            // 
            // btnDictAdd
            // 
            this.btnDictAdd.Location = new System.Drawing.Point(12, 137);
            this.btnDictAdd.Name = "btnDictAdd";
            this.btnDictAdd.Size = new System.Drawing.Size(187, 22);
            this.btnDictAdd.StyleController = this.layoutControl1;
            this.btnDictAdd.TabIndex = 9;
            this.btnDictAdd.Text = "添加字典";
            this.btnDictAdd.Click += new System.EventHandler(this.btnDictAdd_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(375, 111);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(169, 22);
            this.btnCategoryDelete.StyleController = this.layoutControl1;
            this.btnCategoryDelete.TabIndex = 8;
            this.btnCategoryDelete.Text = "删除分类";
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryEdit
            // 
            this.btnCategoryEdit.Location = new System.Drawing.Point(203, 111);
            this.btnCategoryEdit.Name = "btnCategoryEdit";
            this.btnCategoryEdit.Size = new System.Drawing.Size(168, 22);
            this.btnCategoryEdit.StyleController = this.layoutControl1;
            this.btnCategoryEdit.TabIndex = 7;
            this.btnCategoryEdit.Text = "编辑分类";
            this.btnCategoryEdit.Click += new System.EventHandler(this.btnCategoryEdit_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(39, 60);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(505, 47);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(39, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(505, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 5;
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(12, 111);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(187, 22);
            this.btnCategoryAdd.StyleController = this.layoutControl1;
            this.btnCategoryAdd.TabIndex = 4;
            this.btnCategoryAdd.Text = "添加分类";
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(556, 171);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCategoryAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 99);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(191, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(536, 24);
            this.layoutControlItem2.Text = "名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtRemark;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(536, 51);
            this.layoutControlItem3.Text = "备注";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCategoryEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(191, 99);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(172, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCategoryDelete;
            this.layoutControlItem5.Location = new System.Drawing.Point(363, 99);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(173, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnDictAdd;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 125);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(191, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDictEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(191, 125);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(172, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnDictDelete;
            this.layoutControlItem8.Location = new System.Drawing.Point(363, 125);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(173, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtCode;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(536, 24);
            this.layoutControlItem9.Text = "代码";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(24, 14);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dictItemGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(560, 286);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "字典项";
            // 
            // dictItemGrid
            // 
            this.dictItemGrid.AllowFilter = false;
            this.dictItemGrid.AllowGroup = false;
            this.dictItemGrid.AllowSort = false;
            this.dictItemGrid.DataSource = null;
            this.dictItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictItemGrid.Editable = false;
            this.dictItemGrid.Location = new System.Drawing.Point(2, 21);
            this.dictItemGrid.Name = "dictItemGrid";
            this.dictItemGrid.ShowAddMenu = false;
            this.dictItemGrid.ShowFooter = false;
            this.dictItemGrid.ShowLineNumber = true;
            this.dictItemGrid.ShowNavigator = false;
            this.dictItemGrid.Size = new System.Drawing.Size(556, 263);
            this.dictItemGrid.TabIndex = 0;
            // 
            // FrmDictOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmDictOverview";
            this.Text = "字典总览";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnCategoryAdd;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Core.DictTree treeDict;
        private DevExpress.XtraEditors.SimpleButton btnCategoryDelete;
        private DevExpress.XtraEditors.SimpleButton btnCategoryEdit;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnDictDelete;
        private DevExpress.XtraEditors.SimpleButton btnDictEdit;
        private DevExpress.XtraEditors.SimpleButton btnDictAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private Core.DictItemGrid dictItemGrid;
    }
}