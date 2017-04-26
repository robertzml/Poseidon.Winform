namespace Poseidon.Winform.Client
{
    partial class FrmGroupTree
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkCascade = new DevExpress.XtraEditors.CheckEdit();
            this.txtGroupRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtGroupCode = new DevExpress.XtraEditors.TextEdit();
            this.tluGroup = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.bsGroups = new System.Windows.Forms.BindingSource();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupTree = new Poseidon.Winform.Core.GroupChildrenTree();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCascade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tluGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl1, 2);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(839, 114);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "分组选择";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkCascade);
            this.layoutControl1.Controls.Add(this.txtGroupRemark);
            this.layoutControl1.Controls.Add(this.txtGroupCode);
            this.layoutControl1.Controls.Add(this.tluGroup);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(835, 91);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkCascade
            // 
            this.chkCascade.Location = new System.Drawing.Point(642, 36);
            this.chkCascade.Name = "chkCascade";
            this.chkCascade.Properties.Caption = "是否级联显示对象";
            this.chkCascade.Size = new System.Drawing.Size(181, 19);
            this.chkCascade.StyleController = this.layoutControl1;
            this.chkCascade.TabIndex = 7;
            this.chkCascade.CheckedChanged += new System.EventHandler(this.chkCascade_CheckedChanged);
            // 
            // txtGroupRemark
            // 
            this.txtGroupRemark.Location = new System.Drawing.Point(320, 36);
            this.txtGroupRemark.Name = "txtGroupRemark";
            this.txtGroupRemark.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtGroupRemark.Properties.Appearance.Options.UseBackColor = true;
            this.txtGroupRemark.Properties.ReadOnly = true;
            this.txtGroupRemark.Size = new System.Drawing.Size(318, 20);
            this.txtGroupRemark.StyleController = this.layoutControl1;
            this.txtGroupRemark.TabIndex = 6;
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Location = new System.Drawing.Point(63, 36);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtGroupCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtGroupCode.Properties.ReadOnly = true;
            this.txtGroupCode.Size = new System.Drawing.Size(202, 20);
            this.txtGroupCode.StyleController = this.layoutControl1;
            this.txtGroupCode.TabIndex = 5;
            // 
            // tluGroup
            // 
            this.tluGroup.Location = new System.Drawing.Point(63, 12);
            this.tluGroup.Name = "tluGroup";
            this.tluGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tluGroup.Properties.DataSource = this.bsGroups;
            this.tluGroup.Properties.DisplayMember = "Name";
            this.tluGroup.Properties.NullText = "请选择";
            this.tluGroup.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.tluGroup.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.tluGroup.Properties.ValueMember = "Id";
            this.tluGroup.Size = new System.Drawing.Size(760, 20);
            this.tluGroup.StyleController = this.layoutControl1;
            this.tluGroup.TabIndex = 4;
            this.tluGroup.EditValueChanged += new System.EventHandler(this.tluGroup_EditValueChanged);
            // 
            // bsGroups
            // 
            this.bsGroups.DataSource = typeof(Poseidon.Core.DL.Group);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.DataSource = this.bsGroups;
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(835, 91);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tluGroup;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(815, 24);
            this.layoutControlItem1.Text = "分组";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtGroupCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(257, 47);
            this.layoutControlItem2.Text = "分组代码";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtGroupRemark;
            this.layoutControlItem3.Location = new System.Drawing.Point(257, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(373, 47);
            this.layoutControlItem3.Text = "备注";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkCascade;
            this.layoutControlItem4.Location = new System.Drawing.Point(630, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(185, 47);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupTree);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(394, 404);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "分组树列表";
            // 
            // groupTree
            // 
            this.groupTree.CascadeEntity = false;
            this.groupTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTree.Location = new System.Drawing.Point(2, 21);
            this.groupTree.Name = "groupTree";
            this.groupTree.ShowFindPanel = false;
            this.groupTree.Size = new System.Drawing.Size(390, 381);
            this.groupTree.TabIndex = 0;
            // 
            // FrmGroupTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmGroupTree";
            this.Text = "分组树";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCascade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tluGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TreeListLookUpEdit tluGroup;
        private System.Windows.Forms.BindingSource bsGroups;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtGroupRemark;
        private DevExpress.XtraEditors.TextEdit txtGroupCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckEdit chkCascade;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Core.GroupChildrenTree groupTree;
    }
}