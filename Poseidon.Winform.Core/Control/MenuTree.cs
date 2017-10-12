using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Winform.Core
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Core.DL;

    /// <summary>
    /// 菜单树形控件
    /// </summary>
    public partial class MenuTree : UserControl
    {
        #region Constructor
        public MenuTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入数据
        /// </summary>
        private void LoadData()
        {
            this.bsMenu.DataSource = CallerFactory<IMenuService>.Instance.FindAll().OrderBy(r => r.Sort);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            this.LoadData();
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        public void RefreshData()
        {
            this.LoadData();
        }

        /// <summary>
        /// 展开节点
        /// </summary>
        public void Expand()
        {
            this.tlMenu.ExpandAll();
        }
        #endregion //Method
    }
}
