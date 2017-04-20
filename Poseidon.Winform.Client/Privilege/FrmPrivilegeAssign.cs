using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Client
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 权限分配窗体
    /// </summary>
    public partial class FrmPrivilegeAssign : BaseMdiForm
    {
        #region Constructor
        public FrmPrivilegeAssign()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.bsRole.DataSource = CallerFactory<IRoleService>.Instance.FindAll();

            base.InitForm();
        }
        #endregion //Function
    }
}
