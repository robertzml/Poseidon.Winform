namespace Poseidon.Winform.Test
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivilegeMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivilegeAssign = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRole = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenu,
            this.menuPrivilegeMan,
            this.menuPrivilegeAssign,
            this.menuUser,
            this.menuRole});
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            // 
            // menuMenu
            // 
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(152, 22);
            this.menuMenu.Text = "菜单管理";
            this.menuMenu.Click += new System.EventHandler(this.menuMenu_Click);
            // 
            // menuPrivilegeMan
            // 
            this.menuPrivilegeMan.Name = "menuPrivilegeMan";
            this.menuPrivilegeMan.Size = new System.Drawing.Size(152, 22);
            this.menuPrivilegeMan.Text = "权限管理";
            this.menuPrivilegeMan.Click += new System.EventHandler(this.menuPrivilegeMan_Click);
            // 
            // menuPrivilegeAssign
            // 
            this.menuPrivilegeAssign.Name = "menuPrivilegeAssign";
            this.menuPrivilegeAssign.Size = new System.Drawing.Size(124, 22);
            this.menuPrivilegeAssign.Text = "权限分配";
            // 
            // menuUser
            // 
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(124, 22);
            this.menuUser.Text = "用户管理";
            // 
            // menuRole
            // 
            this.menuRole.Name = "menuRole";
            this.menuRole.Size = new System.Drawing.Size(124, 22);
            this.menuRole.Text = "角色管理";
            this.menuRole.Click += new System.EventHandler(this.menuRole_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 508);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMenu;
        private System.Windows.Forms.ToolStripMenuItem menuPrivilegeMan;
        private System.Windows.Forms.ToolStripMenuItem menuPrivilegeAssign;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem menuRole;
    }
}

