﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Client
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 分组总览窗体
    /// </summary>
    public partial class FrmGroupOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选中分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public FrmGroupOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化窗体
        /// </summary>
        protected override void InitForm()
        {
            LoadGroupsTree();
            base.InitForm();
        }

        /// <summary>
        /// 载入分组树形列表
        /// </summary>
        private void LoadGroupsTree()
        {
            var groups = CallerFactory<IGroupService>.Instance.FindAll().ToList();
            //var groups = BusinessFactory<GroupBusiness>.Instance.FindAll().ToList();
            this.trGroup.DataSource = groups;
        }

        /// <summary>
        /// 设置分组基本信息
        /// </summary>
        private void SetGroupInfo()
        {
            this.txtName.Text = this.currentGroup.Name;
            this.txtCode.Text = this.currentGroup.Code;
            this.txtStatus.Text = this.currentGroup.Status.ToString();
            this.txtRemark.Text = this.currentGroup.Remark;
        }

        /// <summary>
        /// 载入包含组织
        /// </summary>
        private void LoadOrganizations()
        {
            var data = BusinessFactory<GroupBusiness>.Instance.FindAllItems(this.currentGroup.Id).ToList();
            this.groupItemGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择分组
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void trGroup_GroupSelected(object arg1, EventArgs arg2)
        {
            this.currentGroup = this.trGroup.GetCurrentSelect();
            if (this.currentGroup == null)
                return;

            SetGroupInfo();
            LoadOrganizations();
        }

        /// <summary>
        /// 添加分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmGroupAdd));
            LoadGroupsTree();
        }

        /// <summary>
        /// 编辑分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmGroupEdit), new object[] { this.currentGroup.Id });
            LoadGroupsTree();
        }

        /// <summary>
        /// 删除分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.currentGroup == null)
                return;
            if (MessageUtil.ConfirmYesNo("是否确认删除该分组") == DialogResult.Yes)
            {
                try
                {
                    BusinessFactory<GroupBusiness>.Instance.Delete(this.currentGroup);
                    LoadGroupsTree();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }

        /// <summary>
        /// 绑定模型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModelTypeBind_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmModelTypeBind), new object[] { this.currentGroup.Id });
            LoadGroupsTree();
        }

        /// <summary>
        /// 选择组织
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrganizationSelect_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmOrganizationSelect), new object[] { this.currentGroup.Id });
            LoadGroupsTree();
        }
        #endregion //Event
    }
}
