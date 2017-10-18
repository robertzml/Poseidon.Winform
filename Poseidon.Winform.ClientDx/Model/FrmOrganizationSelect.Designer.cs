namespace Poseidon.Winform.ClientDx
{
    partial class FrmOrganizationSelect
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.luModelTypes = new DevExpress.XtraEditors.LookUpEdit();
            this.bsModelType = new System.Windows.Forms.BindingSource(this.components);
            this.btnMoveOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveIn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemGrid = new Poseidon.Winform.Core.GroupItemGrid();
            this.ogridLeft = new Poseidon.Winform.Core.OrganizationGrid();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luModelTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(790, 18);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(681, 18);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.groupControl1);
            this.plFill.Size = new System.Drawing.Size(884, 441);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 441);
            this.plBottom.Size = new System.Drawing.Size(884, 60);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(884, 441);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "组织列表";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.itemGrid);
            this.layoutControl1.Controls.Add(this.luModelTypes);
            this.layoutControl1.Controls.Add(this.btnMoveOut);
            this.layoutControl1.Controls.Add(this.btnMoveIn);
            this.layoutControl1.Controls.Add(this.ogridLeft);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(880, 418);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // luModelTypes
            // 
            this.luModelTypes.Location = new System.Drawing.Point(63, 12);
            this.luModelTypes.Name = "luModelTypes";
            this.luModelTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luModelTypes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "备注", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luModelTypes.Properties.DataSource = this.bsModelType;
            this.luModelTypes.Properties.DisplayMember = "Name";
            this.luModelTypes.Properties.NullText = "请选择";
            this.luModelTypes.Properties.ShowFooter = false;
            this.luModelTypes.Properties.ValueMember = "Code";
            this.luModelTypes.Size = new System.Drawing.Size(350, 20);
            this.luModelTypes.StyleController = this.layoutControl1;
            this.luModelTypes.TabIndex = 8;
            this.luModelTypes.EditValueChanged += new System.EventHandler(this.luModelTypes_EditValueChanged);
            // 
            // bsModelType
            // 
            this.bsModelType.DataSource = typeof(Poseidon.Core.DL.ModelType);
            // 
            // btnMoveOut
            // 
            this.btnMoveOut.Location = new System.Drawing.Point(417, 223);
            this.btnMoveOut.Name = "btnMoveOut";
            this.btnMoveOut.Size = new System.Drawing.Size(46, 22);
            this.btnMoveOut.StyleController = this.layoutControl1;
            this.btnMoveOut.TabIndex = 7;
            this.btnMoveOut.Text = "<";
            this.btnMoveOut.Click += new System.EventHandler(this.btnMoveOut_Click);
            // 
            // btnMoveIn
            // 
            this.btnMoveIn.Location = new System.Drawing.Point(417, 197);
            this.btnMoveIn.Name = "btnMoveIn";
            this.btnMoveIn.Size = new System.Drawing.Size(46, 22);
            this.btnMoveIn.StyleController = this.layoutControl1;
            this.btnMoveIn.TabIndex = 6;
            this.btnMoveIn.Text = ">";
            this.btnMoveIn.Click += new System.EventHandler(this.btnMoveIn_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 50D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition2.Height = 50D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition3.Height = 26D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition4.Height = 26D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition5.Height = 50D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.layoutControlGroup1.Size = new System.Drawing.Size(880, 418);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnMoveIn;
            this.layoutControlItem3.Location = new System.Drawing.Point(405, 185);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(50, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnMoveOut;
            this.layoutControlItem4.Location = new System.Drawing.Point(405, 211);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(50, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.luModelTypes;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(405, 24);
            this.layoutControlItem5.Text = "模型类型";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // itemGrid
            // 
            this.itemGrid.AllowFilter = false;
            this.itemGrid.AllowGroup = false;
            this.itemGrid.AllowSort = true;
            this.itemGrid.DataSource = null;
            this.itemGrid.Editable = true;
            this.itemGrid.EnableMasterView = true;
            this.itemGrid.EnableMultiSelect = false;
            this.itemGrid.Location = new System.Drawing.Point(467, 53);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ShowAddMenu = false;
            this.itemGrid.ShowFooter = false;
            this.itemGrid.ShowLineNumber = true;
            this.itemGrid.ShowMenu = false;
            this.itemGrid.ShowNavigator = false;
            this.itemGrid.Size = new System.Drawing.Size(401, 353);
            this.itemGrid.TabIndex = 9;
            // 
            // ogridLeft
            // 
            this.ogridLeft.AllowFilter = true;
            this.ogridLeft.AllowGroup = false;
            this.ogridLeft.AllowSort = true;
            this.ogridLeft.DataSource = null;
            this.ogridLeft.Editable = false;
            this.ogridLeft.EnableMasterView = false;
            this.ogridLeft.EnableMultiCheckSelect = true;
            this.ogridLeft.EnableMultiSelect = true;
            this.ogridLeft.Location = new System.Drawing.Point(12, 53);
            this.ogridLeft.Name = "ogridLeft";
            this.ogridLeft.ShowAddMenu = false;
            this.ogridLeft.ShowFooter = false;
            this.ogridLeft.ShowLineNumber = true;
            this.ogridLeft.ShowMenu = false;
            this.ogridLeft.ShowNavigator = false;
            this.ogridLeft.Size = new System.Drawing.Size(401, 353);
            this.ogridLeft.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ogridLeft;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.OptionsTableLayoutItem.RowSpan = 4;
            this.layoutControlItem1.Size = new System.Drawing.Size(405, 374);
            this.layoutControlItem1.Text = "模型组织";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.itemGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(455, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.OptionsTableLayoutItem.RowSpan = 4;
            this.layoutControlItem2.Size = new System.Drawing.Size(405, 374);
            this.layoutControlItem2.Text = "已有组织";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // FrmOrganizationSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Name = "FrmOrganizationSelect";
            this.Text = "组织选择";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luModelTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit luModelTypes;
        private System.Windows.Forms.BindingSource bsModelType;
        private DevExpress.XtraEditors.SimpleButton btnMoveOut;
        private DevExpress.XtraEditors.SimpleButton btnMoveIn;
        private Core.OrganizationGrid ogridLeft;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private Core.GroupItemGrid itemGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}