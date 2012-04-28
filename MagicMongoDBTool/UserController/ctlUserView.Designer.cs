﻿using System.Windows.Forms;
namespace MagicMongoDBTool
{
    partial class ctlUserView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserStripButton = new System.Windows.Forms.ToolStripButton();
            this.ChangePasswordStripButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveUserStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabDataShower.SuspendLayout();
            this.tabTreeView.SuspendLayout();
            this.tabTableView.SuspendLayout();
            this.tabTextView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstData_MouseDoubleClick);
            this.lstData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstData_MouseClick);
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Image = global::MagicMongoDBTool.Properties.Resources.AddUserToDB;
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.AddUserToolStripMenuItem.Text = "Create User";
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Image = global::MagicMongoDBTool.Properties.Resources.UserPassword;
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ChangePasswordToolStripMenuItem.Text = "Change Password";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordStripButton_Click);
            // 
            // RemoveUserToolStripMenuItem
            // 
            this.RemoveUserToolStripMenuItem.Image = global::MagicMongoDBTool.Properties.Resources.DelUser;
            this.RemoveUserToolStripMenuItem.Name = "RemoveUserToolStripMenuItem";
            this.RemoveUserToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.RemoveUserToolStripMenuItem.Text = "Remove User";
            this.RemoveUserToolStripMenuItem.Click += new System.EventHandler(this.RemoveUserStripButton_Click);
            // 
            // AddUserStripButton
            // 
            this.AddUserStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddUserStripButton.Image = global::MagicMongoDBTool.Properties.Resources.AddUserToDB;
            this.AddUserStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddUserStripButton.Name = "AddUserStripButton";
            this.AddUserStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddUserStripButton.Text = "Add User";
            this.AddUserStripButton.Click += new System.EventHandler(this.AddUserStripButton_Click);
            // 
            // ChangePasswordStripButton
            // 
            this.ChangePasswordStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChangePasswordStripButton.Image = global::MagicMongoDBTool.Properties.Resources.UserPassword;
            this.ChangePasswordStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangePasswordStripButton.Name = "ChangePasswordStripButton";
            this.ChangePasswordStripButton.Size = new System.Drawing.Size(23, 22);
            this.ChangePasswordStripButton.Text = "ChangePassword";
            this.ChangePasswordStripButton.Click += new System.EventHandler(this.ChangePasswordStripButton_Click);
            // 
            // RemoveUserStripButton
            // 
            this.RemoveUserStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveUserStripButton.Image = global::MagicMongoDBTool.Properties.Resources.DelUser;
            this.RemoveUserStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveUserStripButton.Name = "RemoveUserStripButton";
            this.RemoveUserStripButton.Size = new System.Drawing.Size(23, 22);
            this.RemoveUserStripButton.Text = "RemoveUser";
            this.RemoveUserStripButton.Click += new System.EventHandler(this.RemoveUserStripButton_Click);
            // 
            // ctlUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.IsDataView = false;
            this.Name = "ctlUserView";
            this.Load += new System.EventHandler(this.ctlUserView_Load);
            this.tabDataShower.ResumeLayout(false);
            this.tabTreeView.ResumeLayout(false);
            this.tabTableView.ResumeLayout(false);
            this.tabTextView.ResumeLayout(false);
            this.tabTextView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitToolAndMenu(){
            this.ViewtoolStrip.Items.Insert(0, RemoveUserStripButton);
            this.ViewtoolStrip.Items.Insert(0, ChangePasswordStripButton);
            this.ViewtoolStrip.Items.Insert(0, AddUserStripButton);
            this.contextMenuStripMain.Items.Insert(0,RemoveUserToolStripMenuItem);
            this.contextMenuStripMain.Items.Insert(0,ChangePasswordToolStripMenuItem);
            this.contextMenuStripMain.Items.Insert(0,AddUserToolStripMenuItem);
        }

        private ToolStripMenuItem AddUserToolStripMenuItem;
        private ToolStripMenuItem RemoveUserToolStripMenuItem;
        private ToolStripMenuItem ChangePasswordToolStripMenuItem;
        
        private ToolStripButton AddUserStripButton;
        private ToolStripButton ChangePasswordStripButton;
        private ToolStripButton RemoveUserStripButton;
        #endregion
    }
}
