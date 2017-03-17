using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Client
{
    using DevExpress.XtraBars.Ribbon;
    using Poseidon.Common;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 主窗体界面
    /// </summary>
    public partial class MainForm : RibbonForm
    {
        #region Field

        #endregion //Field

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 设置状态栏显示
        /// </summary>
        private void SetStatusBar()
        {
            this.barLoginUser.Caption = string.Format("当前用户：{0}", GlobalAction.CurrentUser.Name);
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = AppConfig.ApplicationName;

            SetStatusBar();
        }

        #region Ribbon Event

        #region Energy
        /// <summary>
        /// 指标总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiTargetOverview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmTargetOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 指标制定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiTargetMake_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmTargetMake";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 人数总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiPopulationOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmPopulationOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 人数管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiPopulationMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmPopulationManage";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 经费总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtFundOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmFundOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 经费管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiFundMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmFundManage";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 部门总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDepartmentOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmDepartmentOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }
        #endregion //Energy

        #region Expense
        /// <summary>
        /// 支出总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExpenseOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmExpenseOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 支出单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExpenseReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmExpenseReceipt";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 支出账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExpenseAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmExpenseAccount";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }
        #endregion //Expense

        /// <summary>
        /// 模型类型总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiModelTypeOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmModelTypeOverview));
        }

        /// <summary>
        /// 分组总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiGroupOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmGroupOverview));
        }

        #region System
        /// <summary>
        /// 字典总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDictOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmDictOverview));
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiUserList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmUserList));
        }

        /// <summary>
        /// 角色列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRoleList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmChangePassword));
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion //System

        #endregion //Ribbon Event

        #endregion //Event

    }
}
