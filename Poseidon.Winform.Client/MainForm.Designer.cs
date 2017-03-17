namespace Poseidon.Winform.Client
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barChildList = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.bbiModelTypeOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExpenseAccount = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGroupOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDepartmentOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPopulationMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFundMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTargetOverview = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTargetMake = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExpenseOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDictOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExpenseReceipt = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUserList = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRoleList = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPopulationOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbtFundOv = new DevExpress.XtraBars.BarButtonItem();
            this.barLoginUser = new DevExpress.XtraBars.BarStaticItem();
            this.bbiChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.rpEnergy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTarget = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTargetBase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpExpense = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgExpenseInfo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpOrganization = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystemFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPrivilege = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPersonnel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barChildList,
            this.bbiModelTypeOv,
            this.bbiExpenseAccount,
            this.bbiGroupOv,
            this.bbiDepartmentOv,
            this.bbiPopulationMan,
            this.bbiFundMan,
            this.bbiTargetOverview,
            this.bbiTargetMake,
            this.bbiExpenseOv,
            this.bbiDictOv,
            this.bbiExpenseReceipt,
            this.bbiUserList,
            this.bbiRoleList,
            this.bbiPopulationOv,
            this.bbtFundOv,
            this.barLoginUser,
            this.bbiChangePassword});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpEnergy,
            this.rpExpense,
            this.rpOrganization,
            this.rpSystem});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(924, 147);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // barChildList
            // 
            this.barChildList.Caption = "窗口";
            this.barChildList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barChildList.Id = 3;
            this.barChildList.Name = "barChildList";
            // 
            // bbiModelTypeOv
            // 
            this.bbiModelTypeOv.Caption = "模型类型总览";
            this.bbiModelTypeOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiModelTypeOv.Glyph")));
            this.bbiModelTypeOv.Id = 17;
            this.bbiModelTypeOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiModelTypeOv.LargeGlyph")));
            this.bbiModelTypeOv.Name = "bbiModelTypeOv";
            this.bbiModelTypeOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModelTypeOv_ItemClick);
            // 
            // bbiExpenseAccount
            // 
            this.bbiExpenseAccount.Caption = "支出账户";
            this.bbiExpenseAccount.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiExpenseAccount.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExpenseAccount.Glyph")));
            this.bbiExpenseAccount.Id = 18;
            this.bbiExpenseAccount.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExpenseAccount.LargeGlyph")));
            this.bbiExpenseAccount.Name = "bbiExpenseAccount";
            this.bbiExpenseAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExpenseAccount_ItemClick);
            // 
            // bbiGroupOv
            // 
            this.bbiGroupOv.Caption = "分组总览";
            this.bbiGroupOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiGroupOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiGroupOv.Glyph")));
            this.bbiGroupOv.Id = 19;
            this.bbiGroupOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiGroupOv.LargeGlyph")));
            this.bbiGroupOv.Name = "bbiGroupOv";
            this.bbiGroupOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGroupOv_ItemClick);
            // 
            // bbiDepartmentOv
            // 
            this.bbiDepartmentOv.Caption = "部门总览";
            this.bbiDepartmentOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiDepartmentOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiDepartmentOv.Glyph")));
            this.bbiDepartmentOv.Id = 21;
            this.bbiDepartmentOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiDepartmentOv.LargeGlyph")));
            this.bbiDepartmentOv.Name = "bbiDepartmentOv";
            this.bbiDepartmentOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDepartmentOv_ItemClick);
            // 
            // bbiPopulationMan
            // 
            this.bbiPopulationMan.Caption = "人数管理";
            this.bbiPopulationMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPopulationMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPopulationMan.Glyph")));
            this.bbiPopulationMan.Id = 22;
            this.bbiPopulationMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPopulationMan.LargeGlyph")));
            this.bbiPopulationMan.Name = "bbiPopulationMan";
            this.bbiPopulationMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPopulationMan_ItemClick);
            // 
            // bbiFundMan
            // 
            this.bbiFundMan.Caption = "经费管理";
            this.bbiFundMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiFundMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiFundMan.Glyph")));
            this.bbiFundMan.Id = 23;
            this.bbiFundMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiFundMan.LargeGlyph")));
            this.bbiFundMan.Name = "bbiFundMan";
            this.bbiFundMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFundMan_ItemClick);
            // 
            // bbiTargetOverview
            // 
            this.bbiTargetOverview.Caption = "指标总览";
            this.bbiTargetOverview.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiTargetOverview.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiTargetOverview.Glyph")));
            this.bbiTargetOverview.Id = 24;
            this.bbiTargetOverview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiTargetOverview.LargeGlyph")));
            this.bbiTargetOverview.Name = "bbiTargetOverview";
            this.bbiTargetOverview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTargetOverview_ItemClick);
            // 
            // bbiTargetMake
            // 
            this.bbiTargetMake.Caption = "指标制定";
            this.bbiTargetMake.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiTargetMake.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiTargetMake.Glyph")));
            this.bbiTargetMake.Id = 25;
            this.bbiTargetMake.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiTargetMake.LargeGlyph")));
            this.bbiTargetMake.Name = "bbiTargetMake";
            this.bbiTargetMake.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTargetMake_ItemClick);
            // 
            // bbiExpenseOv
            // 
            this.bbiExpenseOv.Caption = "支出总览";
            this.bbiExpenseOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiExpenseOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExpenseOv.Glyph")));
            this.bbiExpenseOv.Id = 27;
            this.bbiExpenseOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExpenseOv.LargeGlyph")));
            this.bbiExpenseOv.Name = "bbiExpenseOv";
            this.bbiExpenseOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExpenseOv_ItemClick);
            // 
            // bbiDictOv
            // 
            this.bbiDictOv.Caption = "字典总览";
            this.bbiDictOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiDictOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiDictOv.Glyph")));
            this.bbiDictOv.Id = 28;
            this.bbiDictOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiDictOv.LargeGlyph")));
            this.bbiDictOv.Name = "bbiDictOv";
            this.bbiDictOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDictOv_ItemClick);
            // 
            // bbiExpenseReceipt
            // 
            this.bbiExpenseReceipt.Caption = "支出单据";
            this.bbiExpenseReceipt.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiExpenseReceipt.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExpenseReceipt.Glyph")));
            this.bbiExpenseReceipt.Id = 29;
            this.bbiExpenseReceipt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExpenseReceipt.LargeGlyph")));
            this.bbiExpenseReceipt.Name = "bbiExpenseReceipt";
            this.bbiExpenseReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExpenseReceipt_ItemClick);
            // 
            // bbiUserList
            // 
            this.bbiUserList.Caption = "用户列表";
            this.bbiUserList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiUserList.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiUserList.Glyph")));
            this.bbiUserList.Id = 30;
            this.bbiUserList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiUserList.LargeGlyph")));
            this.bbiUserList.Name = "bbiUserList";
            this.bbiUserList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUserList_ItemClick);
            // 
            // bbiRoleList
            // 
            this.bbiRoleList.Caption = "角色列表";
            this.bbiRoleList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiRoleList.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiRoleList.Glyph")));
            this.bbiRoleList.Id = 31;
            this.bbiRoleList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiRoleList.LargeGlyph")));
            this.bbiRoleList.Name = "bbiRoleList";
            this.bbiRoleList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRoleList_ItemClick);
            // 
            // bbiPopulationOv
            // 
            this.bbiPopulationOv.Caption = "人数总览";
            this.bbiPopulationOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPopulationOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPopulationOv.Glyph")));
            this.bbiPopulationOv.Id = 32;
            this.bbiPopulationOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPopulationOv.LargeGlyph")));
            this.bbiPopulationOv.Name = "bbiPopulationOv";
            this.bbiPopulationOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPopulationOv_ItemClick);
            // 
            // bbtFundOv
            // 
            this.bbtFundOv.Caption = "经费总览";
            this.bbtFundOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtFundOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtFundOv.Glyph")));
            this.bbtFundOv.Id = 33;
            this.bbtFundOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtFundOv.LargeGlyph")));
            this.bbtFundOv.Name = "bbtFundOv";
            this.bbtFundOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtFundOv_ItemClick);
            // 
            // barLoginUser
            // 
            this.barLoginUser.Caption = "当前用户：";
            this.barLoginUser.Glyph = ((System.Drawing.Image)(resources.GetObject("barLoginUser.Glyph")));
            this.barLoginUser.Id = 34;
            this.barLoginUser.Name = "barLoginUser";
            this.barLoginUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbiChangePassword
            // 
            this.bbiChangePassword.Caption = "修改密码";
            this.bbiChangePassword.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiChangePassword.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiChangePassword.Glyph")));
            this.bbiChangePassword.Id = 35;
            this.bbiChangePassword.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiChangePassword.LargeGlyph")));
            this.bbiChangePassword.Name = "bbiChangePassword";
            this.bbiChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangePassword_ItemClick);
            // 
            // rpEnergy
            // 
            this.rpEnergy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTarget,
            this.rpgTargetBase});
            this.rpEnergy.Name = "rpEnergy";
            this.rpEnergy.Text = "用能管理";
            // 
            // rpgTarget
            // 
            this.rpgTarget.ItemLinks.Add(this.bbiTargetOverview);
            this.rpgTarget.ItemLinks.Add(this.bbiTargetMake);
            this.rpgTarget.ItemLinks.Add(this.bbiPopulationOv);
            this.rpgTarget.ItemLinks.Add(this.bbiPopulationMan);
            this.rpgTarget.ItemLinks.Add(this.bbtFundOv);
            this.rpgTarget.ItemLinks.Add(this.bbiFundMan);
            this.rpgTarget.Name = "rpgTarget";
            this.rpgTarget.Text = "指标化管理";
            // 
            // rpgTargetBase
            // 
            this.rpgTargetBase.ItemLinks.Add(this.bbiDepartmentOv);
            this.rpgTargetBase.Name = "rpgTargetBase";
            this.rpgTargetBase.Text = "基础数据";
            // 
            // rpExpense
            // 
            this.rpExpense.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgExpenseInfo});
            this.rpExpense.Name = "rpExpense";
            this.rpExpense.Text = "费用支出";
            // 
            // rpgExpenseInfo
            // 
            this.rpgExpenseInfo.ItemLinks.Add(this.bbiExpenseOv);
            this.rpgExpenseInfo.ItemLinks.Add(this.bbiExpenseReceipt);
            this.rpgExpenseInfo.ItemLinks.Add(this.bbiExpenseAccount);
            this.rpgExpenseInfo.Name = "rpgExpenseInfo";
            this.rpgExpenseInfo.Text = "基本信息";
            // 
            // rpOrganization
            // 
            this.rpOrganization.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgGroup});
            this.rpOrganization.Name = "rpOrganization";
            this.rpOrganization.Text = "组织管理";
            // 
            // rpgGroup
            // 
            this.rpgGroup.ItemLinks.Add(this.bbiModelTypeOv);
            this.rpgGroup.ItemLinks.Add(this.bbiGroupOv);
            this.rpgGroup.Name = "rpgGroup";
            this.rpgGroup.Text = "组织分组";
            // 
            // rpSystem
            // 
            this.rpSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystemFunction,
            this.rpgPrivilege,
            this.rpgPersonnel});
            this.rpSystem.Name = "rpSystem";
            this.rpSystem.Text = "系统管理";
            // 
            // rpgSystemFunction
            // 
            this.rpgSystemFunction.ItemLinks.Add(this.bbiDictOv);
            this.rpgSystemFunction.ItemLinks.Add(this.barChildList);
            this.rpgSystemFunction.Name = "rpgSystemFunction";
            this.rpgSystemFunction.Text = "系统功能";
            // 
            // rpgPrivilege
            // 
            this.rpgPrivilege.ItemLinks.Add(this.bbiUserList);
            this.rpgPrivilege.ItemLinks.Add(this.bbiRoleList);
            this.rpgPrivilege.Name = "rpgPrivilege";
            this.rpgPrivilege.Text = "权限管理";
            // 
            // rpgPersonnel
            // 
            this.rpgPersonnel.ItemLinks.Add(this.bbiChangePassword);
            this.rpgPersonnel.Name = "rpgPersonnel";
            this.rpgPersonnel.Text = "个人信息";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barLoginUser);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 557);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(924, 31);
            // 
            // tabMdiManager
            // 
            this.tabMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.tabMdiManager.MdiParent = this;
            this.tabMdiManager.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeader;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "能源科数据管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystemFunction;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdiManager;
        private DevExpress.XtraBars.BarMdiChildrenListItem barChildList;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpOrganization;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGroup;
        private DevExpress.XtraBars.BarButtonItem bbiModelTypeOv;
        private DevExpress.XtraBars.BarButtonItem bbiExpenseAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpExpense;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExpenseInfo;
        private DevExpress.XtraBars.BarButtonItem bbiGroupOv;
        private DevExpress.XtraBars.BarButtonItem bbiDepartmentOv;
        private DevExpress.XtraBars.BarButtonItem bbiPopulationMan;
        private DevExpress.XtraBars.BarButtonItem bbiFundMan;
        private DevExpress.XtraBars.BarButtonItem bbiTargetOverview;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpEnergy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTarget;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTargetBase;
        private DevExpress.XtraBars.BarButtonItem bbiTargetMake;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPrivilege;
        private DevExpress.XtraBars.BarButtonItem bbiExpenseOv;
        private DevExpress.XtraBars.BarButtonItem bbiDictOv;
        private DevExpress.XtraBars.BarButtonItem bbiExpenseReceipt;
        private DevExpress.XtraBars.BarButtonItem bbiUserList;
        private DevExpress.XtraBars.BarButtonItem bbiRoleList;
        private DevExpress.XtraBars.BarButtonItem bbiPopulationOv;
        private DevExpress.XtraBars.BarButtonItem bbtFundOv;
        private DevExpress.XtraBars.BarStaticItem barLoginUser;
        private DevExpress.XtraBars.BarButtonItem bbiChangePassword;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPersonnel;
    }
}

