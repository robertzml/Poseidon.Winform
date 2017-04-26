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
            this.bbiUserMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRoleMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPopulationOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFundOv = new DevExpress.XtraBars.BarButtonItem();
            this.barLoginUser = new DevExpress.XtraBars.BarStaticItem();
            this.bbiChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMeasureMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMeasureOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSettlementMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSettlementOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrivilegeMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrivilegeAssign = new DevExpress.XtraBars.BarButtonItem();
            this.rpEnergy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTarget = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgMeasure = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSettlement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.rpBase = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.bbiUserMan,
            this.bbiRoleMan,
            this.bbiPopulationOv,
            this.bbiFundOv,
            this.barLoginUser,
            this.bbiChangePassword,
            this.bbiMeasureMan,
            this.bbiMeasureOv,
            this.bbiSettlementMan,
            this.bbiSettlementOv,
            this.bbiExit,
            this.bbiPrivilegeMan,
            this.bbiPrivilegeAssign});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 8;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpEnergy,
            this.rpExpense,
            this.rpOrganization,
            this.rpSystem,
            this.rpBase});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(924, 147);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // barChildList
            // 
            this.barChildList.Caption = "窗口";
            this.barChildList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barChildList.Glyph = ((System.Drawing.Image)(resources.GetObject("barChildList.Glyph")));
            this.barChildList.Id = 3;
            this.barChildList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barChildList.LargeGlyph")));
            this.barChildList.Name = "barChildList";
            // 
            // bbiModelTypeOv
            // 
            this.bbiModelTypeOv.Caption = "模型类型总览";
            this.bbiModelTypeOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiModelTypeOv.Glyph")));
            this.bbiModelTypeOv.Id = 17;
            this.bbiModelTypeOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiModelTypeOv.LargeGlyph")));
            this.bbiModelTypeOv.Name = "bbiModelTypeOv";
            this.bbiModelTypeOv.Tag = "Organization.ModelType";
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
            this.bbiExpenseAccount.Tag = "Expense.Account";
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
            this.bbiGroupOv.Tag = "Organization.Group";
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
            this.bbiDepartmentOv.Tag = "Energy.Base.Department";
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
            this.bbiPopulationMan.Tag = "Energy.Target.PopulationManage";
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
            this.bbiFundMan.Tag = "Energy.Target.FundManage";
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
            this.bbiTargetOverview.Tag = "Energy.Target.Overview";
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
            this.bbiTargetMake.Tag = "Energy.Target.Make";
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
            this.bbiExpenseOv.Tag = "Expense.Overview";
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
            this.bbiDictOv.Tag = "System.Dict";
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
            this.bbiExpenseReceipt.Tag = "Expense.Receipt";
            this.bbiExpenseReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExpenseReceipt_ItemClick);
            // 
            // bbiUserMan
            // 
            this.bbiUserMan.Caption = "用户管理";
            this.bbiUserMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiUserMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiUserMan.Glyph")));
            this.bbiUserMan.Id = 30;
            this.bbiUserMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiUserMan.LargeGlyph")));
            this.bbiUserMan.Name = "bbiUserMan";
            this.bbiUserMan.Tag = "System.User";
            this.bbiUserMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUserMan_ItemClick);
            // 
            // bbiRoleMan
            // 
            this.bbiRoleMan.Caption = "角色管理";
            this.bbiRoleMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiRoleMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiRoleMan.Glyph")));
            this.bbiRoleMan.Id = 31;
            this.bbiRoleMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiRoleMan.LargeGlyph")));
            this.bbiRoleMan.Name = "bbiRoleMan";
            this.bbiRoleMan.Tag = "System.Role";
            this.bbiRoleMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRoleMan_ItemClick);
            // 
            // bbiPopulationOv
            // 
            this.bbiPopulationOv.Caption = "人数总览";
            this.bbiPopulationOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPopulationOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPopulationOv.Glyph")));
            this.bbiPopulationOv.Id = 32;
            this.bbiPopulationOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPopulationOv.LargeGlyph")));
            this.bbiPopulationOv.Name = "bbiPopulationOv";
            this.bbiPopulationOv.Tag = "Energy.Target.PopulationOverview";
            this.bbiPopulationOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPopulationOv_ItemClick);
            // 
            // bbiFundOv
            // 
            this.bbiFundOv.Caption = "经费总览";
            this.bbiFundOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiFundOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiFundOv.Glyph")));
            this.bbiFundOv.Id = 33;
            this.bbiFundOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiFundOv.LargeGlyph")));
            this.bbiFundOv.Name = "bbiFundOv";
            this.bbiFundOv.Tag = "Energy.Target.FundOverview";
            this.bbiFundOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFundOv_ItemClick);
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
            // bbiMeasureMan
            // 
            this.bbiMeasureMan.Caption = "计量管理";
            this.bbiMeasureMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiMeasureMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiMeasureMan.Glyph")));
            this.bbiMeasureMan.Id = 1;
            this.bbiMeasureMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiMeasureMan.LargeGlyph")));
            this.bbiMeasureMan.Name = "bbiMeasureMan";
            this.bbiMeasureMan.Tag = "Energy.Measure.Manage";
            this.bbiMeasureMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMeasureMan_ItemClick);
            // 
            // bbiMeasureOv
            // 
            this.bbiMeasureOv.Caption = "计量总览";
            this.bbiMeasureOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiMeasureOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiMeasureOv.Glyph")));
            this.bbiMeasureOv.Id = 2;
            this.bbiMeasureOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiMeasureOv.LargeGlyph")));
            this.bbiMeasureOv.Name = "bbiMeasureOv";
            this.bbiMeasureOv.Tag = "Energy.Measure.Overview";
            this.bbiMeasureOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMeasureOv_ItemClick);
            // 
            // bbiSettlementMan
            // 
            this.bbiSettlementMan.Caption = "结算管理";
            this.bbiSettlementMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiSettlementMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSettlementMan.Glyph")));
            this.bbiSettlementMan.Id = 3;
            this.bbiSettlementMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSettlementMan.LargeGlyph")));
            this.bbiSettlementMan.Name = "bbiSettlementMan";
            this.bbiSettlementMan.Tag = "Energy.Settlement.Manage";
            this.bbiSettlementMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSettlementMan_ItemClick);
            // 
            // bbiSettlementOv
            // 
            this.bbiSettlementOv.Caption = "结算总览";
            this.bbiSettlementOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiSettlementOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSettlementOv.Glyph")));
            this.bbiSettlementOv.Id = 4;
            this.bbiSettlementOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSettlementOv.LargeGlyph")));
            this.bbiSettlementOv.Name = "bbiSettlementOv";
            this.bbiSettlementOv.Tag = "Energy.Settlement.Overview";
            this.bbiSettlementOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSettlementOv_ItemClick);
            // 
            // bbiExit
            // 
            this.bbiExit.Caption = "退出系统";
            this.bbiExit.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiExit.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExit.Glyph")));
            this.bbiExit.Id = 5;
            this.bbiExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExit.LargeGlyph")));
            this.bbiExit.Name = "bbiExit";
            this.bbiExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExit_ItemClick);
            // 
            // bbiPrivilegeMan
            // 
            this.bbiPrivilegeMan.Caption = "权限管理";
            this.bbiPrivilegeMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPrivilegeMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPrivilegeMan.Glyph")));
            this.bbiPrivilegeMan.Id = 6;
            this.bbiPrivilegeMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPrivilegeMan.LargeGlyph")));
            this.bbiPrivilegeMan.Name = "bbiPrivilegeMan";
            this.bbiPrivilegeMan.Tag = "System.Privilege";
            this.bbiPrivilegeMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrivilegeMan_ItemClick);
            // 
            // bbiPrivilegeAssign
            // 
            this.bbiPrivilegeAssign.Caption = "权限分配";
            this.bbiPrivilegeAssign.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPrivilegeAssign.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPrivilegeAssign.Glyph")));
            this.bbiPrivilegeAssign.Id = 7;
            this.bbiPrivilegeAssign.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPrivilegeAssign.LargeGlyph")));
            this.bbiPrivilegeAssign.Name = "bbiPrivilegeAssign";
            this.bbiPrivilegeAssign.Tag = "System.Privilege";
            this.bbiPrivilegeAssign.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrivilegeAssign_ItemClick);
            // 
            // rpEnergy
            // 
            this.rpEnergy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTarget,
            this.rpgMeasure,
            this.rpgSettlement,
            this.rpgTargetBase});
            this.rpEnergy.Name = "rpEnergy";
            this.rpEnergy.Tag = "Energy";
            this.rpEnergy.Text = "用能管理";
            // 
            // rpgTarget
            // 
            this.rpgTarget.ItemLinks.Add(this.bbiTargetOverview);
            this.rpgTarget.ItemLinks.Add(this.bbiTargetMake);
            this.rpgTarget.ItemLinks.Add(this.bbiPopulationOv);
            this.rpgTarget.ItemLinks.Add(this.bbiPopulationMan);
            this.rpgTarget.ItemLinks.Add(this.bbiFundOv);
            this.rpgTarget.ItemLinks.Add(this.bbiFundMan);
            this.rpgTarget.Name = "rpgTarget";
            this.rpgTarget.Tag = "Energy.Target";
            this.rpgTarget.Text = "指标化管理";
            // 
            // rpgMeasure
            // 
            this.rpgMeasure.ItemLinks.Add(this.bbiMeasureOv);
            this.rpgMeasure.ItemLinks.Add(this.bbiMeasureMan);
            this.rpgMeasure.Name = "rpgMeasure";
            this.rpgMeasure.Tag = "Energy.Measure";
            this.rpgMeasure.Text = "能源计量管理";
            // 
            // rpgSettlement
            // 
            this.rpgSettlement.ItemLinks.Add(this.bbiSettlementOv);
            this.rpgSettlement.ItemLinks.Add(this.bbiSettlementMan);
            this.rpgSettlement.Name = "rpgSettlement";
            this.rpgSettlement.Tag = "Energy.Settlement";
            this.rpgSettlement.Text = "能源结算管理";
            // 
            // rpgTargetBase
            // 
            this.rpgTargetBase.ItemLinks.Add(this.bbiDepartmentOv);
            this.rpgTargetBase.Name = "rpgTargetBase";
            this.rpgTargetBase.Tag = "Energy.Base";
            this.rpgTargetBase.Text = "基础数据";
            // 
            // rpExpense
            // 
            this.rpExpense.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgExpenseInfo});
            this.rpExpense.Name = "rpExpense";
            this.rpExpense.Tag = "Expense";
            this.rpExpense.Text = "费用支出";
            // 
            // rpgExpenseInfo
            // 
            this.rpgExpenseInfo.ItemLinks.Add(this.bbiExpenseOv);
            this.rpgExpenseInfo.ItemLinks.Add(this.bbiExpenseReceipt);
            this.rpgExpenseInfo.ItemLinks.Add(this.bbiExpenseAccount);
            this.rpgExpenseInfo.Name = "rpgExpenseInfo";
            this.rpgExpenseInfo.Tag = "Expense";
            this.rpgExpenseInfo.Text = "基本信息";
            // 
            // rpOrganization
            // 
            this.rpOrganization.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgGroup});
            this.rpOrganization.Name = "rpOrganization";
            this.rpOrganization.Tag = "Organization";
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
            this.rpgPrivilege});
            this.rpSystem.Name = "rpSystem";
            this.rpSystem.Tag = "System";
            this.rpSystem.Text = "系统管理";
            // 
            // rpgSystemFunction
            // 
            this.rpgSystemFunction.ItemLinks.Add(this.bbiDictOv);
            this.rpgSystemFunction.Name = "rpgSystemFunction";
            this.rpgSystemFunction.Text = "系统功能";
            // 
            // rpgPrivilege
            // 
            this.rpgPrivilege.ItemLinks.Add(this.bbiUserMan);
            this.rpgPrivilege.ItemLinks.Add(this.bbiRoleMan);
            this.rpgPrivilege.ItemLinks.Add(this.bbiPrivilegeMan);
            this.rpgPrivilege.ItemLinks.Add(this.bbiPrivilegeAssign);
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
            // rpBase
            // 
            this.rpBase.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgPersonnel,
            this.rpgBase});
            this.rpBase.Name = "rpBase";
            this.rpBase.Text = "基本操作";
            // 
            // rpgBase
            // 
            this.rpgBase.ItemLinks.Add(this.bbiExit);
            this.rpgBase.ItemLinks.Add(this.barChildList);
            this.rpgBase.Name = "rpgBase";
            this.rpgBase.Text = "系统";
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
        private DevExpress.XtraBars.BarButtonItem bbiUserMan;
        private DevExpress.XtraBars.BarButtonItem bbiRoleMan;
        private DevExpress.XtraBars.BarButtonItem bbiPopulationOv;
        private DevExpress.XtraBars.BarButtonItem bbiFundOv;
        private DevExpress.XtraBars.BarStaticItem barLoginUser;
        private DevExpress.XtraBars.BarButtonItem bbiChangePassword;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPersonnel;
        private DevExpress.XtraBars.BarButtonItem bbiMeasureMan;
        private DevExpress.XtraBars.BarButtonItem bbiMeasureOv;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgMeasure;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSettlement;
        private DevExpress.XtraBars.BarButtonItem bbiSettlementMan;
        private DevExpress.XtraBars.BarButtonItem bbiSettlementOv;
        private DevExpress.XtraBars.BarButtonItem bbiExit;
        private DevExpress.XtraBars.BarButtonItem bbiPrivilegeMan;
        private DevExpress.XtraBars.BarButtonItem bbiPrivilegeAssign;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBase;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBase;
    }
}

