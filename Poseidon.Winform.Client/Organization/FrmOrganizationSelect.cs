using System;
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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 组织选择窗体
    /// </summary>
    public partial class FrmOrganizationSelect : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public FrmOrganizationSelect(string groupId)
        {
            InitializeComponent();

            InitData(groupId);
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadModelTypes();
            LoadOrganizations();

            base.InitForm();
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="groupId">分组ID</param>
        private void InitData(string groupId)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(groupId);
        }

        /// <summary>
        /// 载入关联模型类型
        /// </summary>
        private void LoadModelTypes()
        {
            var data = BusinessFactory<ModelTypeBusiness>.Instance.FindWithCodes(this.currentGroup.ModelTypes).ToList();
            this.bsModelType.DataSource = data;
        }

        /// <summary>
        /// 载入已有组织
        /// </summary>
        private void LoadOrganizations()
        {
            var group = BusinessFactory<GroupBusiness>.Instance.FindById(this.currentGroup.Id);
            this.itemGrid.DataSource = group.Items;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 模型类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luModelTypes_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luModelTypes.EditValue == null)
                return;

            this.ogridLeft.DataSource = BusinessFactory<OrganizationBusiness>.Instance.FindByModelType(this.luModelTypes.EditValue.ToString()).ToList();
        }

        /// <summary>
        /// 移入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveIn_Click(object sender, EventArgs e)
        {
            var select = this.ogridLeft.GetCurrentSelect();
            if (select != null && !this.itemGrid.DataSource.Any(r => r.OrganizationId == select.Id))
            {
                GroupItem item = new GroupItem
                {
                    GroupCode = this.currentGroup.Code,
                    OrganizationId = select.Id,
                    ModelType = select.ModelType
                };
                this.itemGrid.DataSource.Add(item);
                this.itemGrid.UpdateBindingData();
            }
        }

        /// <summary>
        /// 移出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveOut_Click(object sender, EventArgs e)
        {
            var select = this.itemGrid.GetCurrentSelect();
            if (select != null)
            {
                this.itemGrid.DataSource.Remove(select);
                this.itemGrid.UpdateBindingData();
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.itemGrid.CloseEditor();

            try
            {
                BusinessFactory<GroupBusiness>.Instance.SetOrganizations(this.currentGroup.Id, this.itemGrid.DataSource);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
