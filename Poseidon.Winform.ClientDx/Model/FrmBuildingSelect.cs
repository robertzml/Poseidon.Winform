using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 建筑选择
    /// </summary>
    public partial class FrmBuildingSelect : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public FrmBuildingSelect(string groupId)
        {
            InitializeComponent();
            InitData(groupId);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="groupId">分组ID</param>
        private void InitData(string groupId)
        {
            this.currentGroup = CallerFactory<IGroupService>.Instance.FindById(groupId);
        }

        protected override void InitForm()
        {
            this.itemGrid.DataSource = this.currentGroup.Items;
            this.bsModelType.DataSource = CallerFactory<IModelTypeService>.Instance.FindWithCodes(this.currentGroup.ModelTypes).Where(r => r.Category == (int)ModelCategory.Building);

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 模型类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luModelType_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luModelType.EditValue == null)
                return;

            this.bulGridLeft.DataSource = CallerFactory<IBuildingService>.Instance.FindByModelType(this.luModelType.EditValue.ToString()).ToList();
        }

        /// <summary>
        /// 移入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveIn_Click(object sender, EventArgs e)
        {
            var rows = this.bulGridLeft.GetSelectedRows();

            foreach (var row in rows)
            {
                if (!this.itemGrid.DataSource.Any(r => r.EntityId == row.Id))
                {
                    GroupItem item = new GroupItem
                    {
                        GroupCode = this.currentGroup.Code,
                        EntityId = row.Id,
                        ModelType = row.ModelType
                    };
                    this.itemGrid.DataSource.Add(item);
                }
            }

            this.itemGrid.UpdateBindingData();
        }

        /// <summary>
        /// 移除
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
                CallerFactory<IGroupService>.Instance.SetGroupItems(this.currentGroup.Id, this.itemGrid.DataSource);

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
