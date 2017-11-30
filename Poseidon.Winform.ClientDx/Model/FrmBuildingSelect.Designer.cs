namespace Poseidon.Winform.ClientDx
{
    partial class FrmBuildingSelect
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.bulGridLeft = new Poseidon.Winform.ClientDx.BuildingGrid();
            this.luModelType = new DevExpress.XtraEditors.LookUpEdit();
            this.bsModelType = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnMoveOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveIn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.itemGrid = new Poseidon.Winform.ClientDx.GroupItemGrid();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luModelType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(792, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(683, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.tableLayoutPanel1);
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
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(411, 435);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "建筑列表";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.bulGridLeft);
            this.layoutControl1.Controls.Add(this.luModelType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(407, 412);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // bulGridLeft
            // 
            this.bulGridLeft.AllowFilter = false;
            this.bulGridLeft.AllowGroup = false;
            this.bulGridLeft.AllowSort = true;
            this.bulGridLeft.DataSource = null;
            this.bulGridLeft.Editable = false;
            this.bulGridLeft.EnableMasterView = false;
            this.bulGridLeft.EnableMultiCheckSelect = true;
            this.bulGridLeft.EnableMultiSelect = true;
            this.bulGridLeft.Location = new System.Drawing.Point(12, 36);
            this.bulGridLeft.Name = "bulGridLeft";
            this.bulGridLeft.ShowAddMenu = false;
            this.bulGridLeft.ShowFooter = false;
            this.bulGridLeft.ShowLineNumber = true;
            this.bulGridLeft.ShowMenu = false;
            this.bulGridLeft.ShowNavigator = false;
            this.bulGridLeft.Size = new System.Drawing.Size(383, 364);
            this.bulGridLeft.TabIndex = 5;
            // 
            // luModelType
            // 
            this.luModelType.Location = new System.Drawing.Point(63, 12);
            this.luModelType.Name = "luModelType";
            this.luModelType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luModelType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "备注", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luModelType.Properties.DataSource = this.bsModelType;
            this.luModelType.Properties.DisplayMember = "Name";
            this.luModelType.Properties.NullText = "请选择";
            this.luModelType.Properties.ValueMember = "Code";
            this.luModelType.Size = new System.Drawing.Size(332, 20);
            this.luModelType.StyleController = this.layoutControl1;
            this.luModelType.TabIndex = 4;
            this.luModelType.EditValueChanged += new System.EventHandler(this.luModelType_EditValueChanged);
            // 
            // bsModelType
            // 
            this.bsModelType.DataSource = typeof(Poseidon.Core.DL.ModelType);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(407, 412);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luModelType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(387, 24);
            this.layoutControlItem1.Text = "模型类型";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.bulGridLeft;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(387, 368);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 441);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnMoveOut);
            this.panelControl1.Controls.Add(this.btnMoveIn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(420, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(44, 435);
            this.panelControl1.TabIndex = 1;
            // 
            // btnMoveOut
            // 
            this.btnMoveOut.Location = new System.Drawing.Point(0, 206);
            this.btnMoveOut.Name = "btnMoveOut";
            this.btnMoveOut.Size = new System.Drawing.Size(44, 23);
            this.btnMoveOut.TabIndex = 1;
            this.btnMoveOut.Text = "<";
            this.btnMoveOut.Click += new System.EventHandler(this.btnMoveOut_Click);
            // 
            // btnMoveIn
            // 
            this.btnMoveIn.Location = new System.Drawing.Point(0, 177);
            this.btnMoveIn.Name = "btnMoveIn";
            this.btnMoveIn.Size = new System.Drawing.Size(44, 23);
            this.btnMoveIn.TabIndex = 0;
            this.btnMoveIn.Text = ">";
            this.btnMoveIn.Click += new System.EventHandler(this.btnMoveIn_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.itemGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(470, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(411, 435);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "已有建筑";
            // 
            // itemGrid
            // 
            this.itemGrid.AllowFilter = false;
            this.itemGrid.AllowGroup = false;
            this.itemGrid.AllowSort = true;
            this.itemGrid.DataSource = null;
            this.itemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGrid.Editable = true;
            this.itemGrid.EnableMasterView = false;
            this.itemGrid.EnableMultiSelect = false;
            this.itemGrid.Location = new System.Drawing.Point(2, 21);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ShowAddMenu = false;
            this.itemGrid.ShowFooter = false;
            this.itemGrid.ShowLineNumber = true;
            this.itemGrid.ShowMenu = false;
            this.itemGrid.ShowNavigator = false;
            this.itemGrid.Size = new System.Drawing.Size(407, 412);
            this.itemGrid.TabIndex = 0;
            // 
            // FrmBuildingSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Name = "FrmBuildingSelect";
            this.Text = "建筑选择";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luModelType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit luModelType;
        private System.Windows.Forms.BindingSource bsModelType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private BuildingGrid bulGridLeft;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnMoveIn;
        private DevExpress.XtraEditors.SimpleButton btnMoveOut;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private GroupItemGrid itemGrid;
    }
}