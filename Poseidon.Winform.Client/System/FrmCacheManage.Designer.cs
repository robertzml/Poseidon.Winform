namespace Poseidon.Winform.Client
{
    partial class FrmCacheManage
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcCache = new DevExpress.XtraGrid.GridControl();
            this.dgvCache = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgcCache);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(843, 533);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "缓存记录";
            // 
            // dgcCache
            // 
            this.dgcCache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcCache.Location = new System.Drawing.Point(2, 61);
            this.dgcCache.MainView = this.dgvCache;
            this.dgcCache.Name = "dgcCache";
            this.dgcCache.Size = new System.Drawing.Size(839, 470);
            this.dgcCache.TabIndex = 0;
            this.dgcCache.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCache});
            // 
            // dgvCache
            // 
            this.dgvCache.GridControl = this.dgcCache;
            this.dgvCache.Name = "dgvCache";
            this.dgvCache.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvCache.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvCache.OptionsBehavior.Editable = false;
            this.dgvCache.OptionsCustomization.AllowFilter = false;
            this.dgvCache.OptionsCustomization.AllowGroup = false;
            this.dgvCache.OptionsFilter.AllowFilterEditor = false;
            this.dgvCache.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvCache.OptionsView.EnableAppearanceOddRow = true;
            this.dgvCache.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(839, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmCacheManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 533);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmCacheManage";
            this.Text = "缓存管理";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcCache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcCache;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCache;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}