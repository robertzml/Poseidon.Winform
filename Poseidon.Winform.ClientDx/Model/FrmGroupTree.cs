using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    using Poseidon.Winform.Core.Utility;

    /// <summary>
    /// 分组树窗体
    /// </summary>
    public partial class FrmGroupTree : BaseMdiForm
    {
        #region Constructor
        public FrmGroupTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.bsGroups.DataSource = CallerFactory<IGroupService>.Instance.FindAll();

            this.tluGroup.Popup += EventUtil.TreeListLookup_Popup;
            base.InitForm();
        }

        /// <summary>
        /// 载入分组树数据
        /// </summary>
        /// <param name="code"></param>
        /// <param name="isCascade"></param>
        private void LoadGroupTree(string code, bool isCascade)
        {
            this.groupTree.SetGroupCode(code, isCascade);
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tluGroup_EditValueChanged(object sender, EventArgs e)
        {
            if (this.tluGroup.EditValue == null)
            {
                this.txtGroupCode.Text = "";
                this.txtGroupRemark.Text = "";
                return;
            }

            var group = this.tluGroup.GetSelectedDataRow() as Group;
            this.txtGroupCode.Text = group.Code;
            this.txtGroupRemark.Text = group.Remark;

            LoadGroupTree(group.Code, this.chkCascade.Checked);
        }

        /// <summary>
        /// 级联显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCascade_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tluGroup.EditValue == null)
                return;

            var group = this.tluGroup.GetSelectedDataRow() as Group;

            LoadGroupTree(group.Code, this.chkCascade.Checked);
        }
        #endregion //Event
    }
}
