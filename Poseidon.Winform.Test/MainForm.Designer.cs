﻿namespace Poseidon.Winform.Test
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
            this.字典管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDict = new System.Windows.Forms.ToolStripMenuItem();
            this.模型管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModelType = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivilegeMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivilegeAssign = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRole = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatasetMan = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttachment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCache = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字典管理ToolStripMenuItem,
            this.模型管理ToolStripMenuItem,
            this.权限管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 字典管理ToolStripMenuItem
            // 
            this.字典管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDict});
            this.字典管理ToolStripMenuItem.Name = "字典管理ToolStripMenuItem";
            this.字典管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.字典管理ToolStripMenuItem.Text = "字典管理";
            // 
            // menuDict
            // 
            this.menuDict.Name = "menuDict";
            this.menuDict.Size = new System.Drawing.Size(152, 22);
            this.menuDict.Text = "字典总览";
            this.menuDict.Click += new System.EventHandler(this.menuDict_Click);
            // 
            // 模型管理ToolStripMenuItem
            // 
            this.模型管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModelType,
            this.menuGroup,
            this.menuTest});
            this.模型管理ToolStripMenuItem.Name = "模型管理ToolStripMenuItem";
            this.模型管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.模型管理ToolStripMenuItem.Text = "模型管理";
            // 
            // menuModelType
            // 
            this.menuModelType.Name = "menuModelType";
            this.menuModelType.Size = new System.Drawing.Size(152, 22);
            this.menuModelType.Text = "模型类型";
            this.menuModelType.Click += new System.EventHandler(this.menuModelType_Click);
            // 
            // menuGroup
            // 
            this.menuGroup.Name = "menuGroup";
            this.menuGroup.Size = new System.Drawing.Size(152, 22);
            this.menuGroup.Text = "分组管理";
            this.menuGroup.Click += new System.EventHandler(this.menuGroup_Click);
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenu,
            this.menuPrivilegeMan,
            this.menuPrivilegeAssign,
            this.menuUser,
            this.menuRole,
            this.menuDatasetMan});
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            // 
            // menuMenu
            // 
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(136, 22);
            this.menuMenu.Text = "菜单管理";
            this.menuMenu.Click += new System.EventHandler(this.menuMenu_Click);
            // 
            // menuPrivilegeMan
            // 
            this.menuPrivilegeMan.Name = "menuPrivilegeMan";
            this.menuPrivilegeMan.Size = new System.Drawing.Size(136, 22);
            this.menuPrivilegeMan.Text = "权限管理";
            this.menuPrivilegeMan.Click += new System.EventHandler(this.menuPrivilegeMan_Click);
            // 
            // menuPrivilegeAssign
            // 
            this.menuPrivilegeAssign.Name = "menuPrivilegeAssign";
            this.menuPrivilegeAssign.Size = new System.Drawing.Size(136, 22);
            this.menuPrivilegeAssign.Text = "权限分配";
            this.menuPrivilegeAssign.Click += new System.EventHandler(this.menuPrivilegeAssign_Click);
            // 
            // menuUser
            // 
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(136, 22);
            this.menuUser.Text = "用户管理";
            this.menuUser.Click += new System.EventHandler(this.menuUser_Click);
            // 
            // menuRole
            // 
            this.menuRole.Name = "menuRole";
            this.menuRole.Size = new System.Drawing.Size(136, 22);
            this.menuRole.Text = "角色管理";
            this.menuRole.Click += new System.EventHandler(this.menuRole_Click);
            // 
            // menuDatasetMan
            // 
            this.menuDatasetMan.Name = "menuDatasetMan";
            this.menuDatasetMan.Size = new System.Drawing.Size(136, 22);
            this.menuDatasetMan.Text = "数据集管理";
            this.menuDatasetMan.Click += new System.EventHandler(this.menuDatasetMan_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAttachment,
            this.menuCache});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // menuAttachment
            // 
            this.menuAttachment.Name = "menuAttachment";
            this.menuAttachment.Size = new System.Drawing.Size(124, 22);
            this.menuAttachment.Text = "附件管理";
            this.menuAttachment.Click += new System.EventHandler(this.menuAttachment_Click);
            // 
            // menuCache
            // 
            this.menuCache.Name = "menuCache";
            this.menuCache.Size = new System.Drawing.Size(124, 22);
            this.menuCache.Text = "缓存管理";
            this.menuCache.Click += new System.EventHandler(this.menuCache_Click);
            // 
            // menuTest
            // 
            this.menuTest.Name = "menuTest";
            this.menuTest.Size = new System.Drawing.Size(152, 22);
            this.menuTest.Text = "测试窗体";
            this.menuTest.Click += new System.EventHandler(this.menuTest_Click);
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
        private System.Windows.Forms.ToolStripMenuItem menuDatasetMan;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAttachment;
        private System.Windows.Forms.ToolStripMenuItem menuCache;
        private System.Windows.Forms.ToolStripMenuItem 字典管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDict;
        private System.Windows.Forms.ToolStripMenuItem 模型管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuModelType;
        private System.Windows.Forms.ToolStripMenuItem menuGroup;
        private System.Windows.Forms.ToolStripMenuItem menuTest;
    }
}

