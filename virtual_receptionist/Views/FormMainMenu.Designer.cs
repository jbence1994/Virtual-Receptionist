﻿namespace virtual_receptionist.View
{
    partial class FormMainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemRoomEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuestDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAccomodationData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHelpCHM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMenuName = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxVRLogo = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxBSLogo = new System.Windows.Forms.PictureBox();
            this.menuStripMainMenu.SuspendLayout();
            this.statusStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBSLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRoomEditor,
            this.toolStripMenuItemGuestDatabase,
            this.toolStripMenuItemBilling,
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemLogout});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(1008, 24);
            this.menuStripMainMenu.TabIndex = 0;
            // 
            // toolStripMenuItemRoomEditor
            // 
            this.toolStripMenuItemRoomEditor.Name = "toolStripMenuItemRoomEditor";
            this.toolStripMenuItemRoomEditor.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItemRoomEditor.Text = "Szobakezelő";
            this.toolStripMenuItemRoomEditor.Click += new System.EventHandler(this.toolStripMenuItemRoomEditor_Click);
            this.toolStripMenuItemRoomEditor.MouseLeave += new System.EventHandler(this.toolStripMenuItemRoomEditor_MouseLeave);
            this.toolStripMenuItemRoomEditor.MouseHover += new System.EventHandler(this.toolStripMenuItemRoomEditor_MouseHover);
            // 
            // toolStripMenuItemGuestDatabase
            // 
            this.toolStripMenuItemGuestDatabase.Name = "toolStripMenuItemGuestDatabase";
            this.toolStripMenuItemGuestDatabase.Size = new System.Drawing.Size(107, 20);
            this.toolStripMenuItemGuestDatabase.Text = "Vendégadatbázis";
            this.toolStripMenuItemGuestDatabase.Click += new System.EventHandler(this.toolStripMenuItemGuestDatabase_Click);
            this.toolStripMenuItemGuestDatabase.MouseLeave += new System.EventHandler(this.toolStripMenuItemGuestDatabase_MouseLeave);
            this.toolStripMenuItemGuestDatabase.MouseHover += new System.EventHandler(this.toolStripMenuItemGuestDatabase_MouseHover);
            // 
            // toolStripMenuItemBilling
            // 
            this.toolStripMenuItemBilling.Name = "toolStripMenuItemBilling";
            this.toolStripMenuItemBilling.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItemBilling.Text = "Számlázás";
            this.toolStripMenuItemBilling.Click += new System.EventHandler(this.toolStripMenuItemBilling_Click);
            this.toolStripMenuItemBilling.MouseLeave += new System.EventHandler(this.toolStripMenuItemBilling_MouseLeave);
            this.toolStripMenuItemBilling.MouseHover += new System.EventHandler(this.toolStripMenuItemBilling_MouseHover);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAccomodationData,
            this.toolStripSeparator1,
            this.toolStripMenuItemHelpCHM,
            this.toolStripMenuItemAboutUs});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItemHelp.Text = "Súgó";
            this.toolStripMenuItemHelp.MouseLeave += new System.EventHandler(this.toolStripMenuItemHelp_MouseLeave);
            this.toolStripMenuItemHelp.MouseHover += new System.EventHandler(this.toolStripMenuItemHelp_MouseHover);
            // 
            // toolStripMenuItemAccomodationData
            // 
            this.toolStripMenuItemAccomodationData.Name = "toolStripMenuItemAccomodationData";
            this.toolStripMenuItemAccomodationData.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemAccomodationData.Text = "Szálláshely adatai";
            this.toolStripMenuItemAccomodationData.Click += new System.EventHandler(this.toolStripMenuItemAccomodationData_Click);
            this.toolStripMenuItemAccomodationData.MouseLeave += new System.EventHandler(this.toolStripMenuItemAccomodationData_MouseLeave);
            this.toolStripMenuItemAccomodationData.MouseHover += new System.EventHandler(this.toolStripMenuItemAccomodationData_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItemHelpCHM
            // 
            this.toolStripMenuItemHelpCHM.Name = "toolStripMenuItemHelpCHM";
            this.toolStripMenuItemHelpCHM.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemHelpCHM.Text = "Segítség";
            this.toolStripMenuItemHelpCHM.Click += new System.EventHandler(this.toolStripMenuItemHelpCHM_Click);
            this.toolStripMenuItemHelpCHM.MouseLeave += new System.EventHandler(this.toolStripMenuItemHelpCHM_MouseLeave);
            this.toolStripMenuItemHelpCHM.MouseHover += new System.EventHandler(this.toolStripMenuItemHelpCHM_MouseHover);
            // 
            // toolStripMenuItemAboutUs
            // 
            this.toolStripMenuItemAboutUs.Name = "toolStripMenuItemAboutUs";
            this.toolStripMenuItemAboutUs.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemAboutUs.Text = "Névjegy";
            this.toolStripMenuItemAboutUs.Click += new System.EventHandler(this.toolStripMenuItemAboutUs_Click);
            this.toolStripMenuItemAboutUs.MouseLeave += new System.EventHandler(this.toolStripMenuItemAboutUs_MouseLeave);
            this.toolStripMenuItemAboutUs.MouseHover += new System.EventHandler(this.toolStripMenuItemAboutUs_MouseHover);
            // 
            // toolStripMenuItemLogout
            // 
            this.toolStripMenuItemLogout.Name = "toolStripMenuItemLogout";
            this.toolStripMenuItemLogout.Size = new System.Drawing.Size(86, 20);
            this.toolStripMenuItemLogout.Text = "Kijelentkezés";
            this.toolStripMenuItemLogout.Click += new System.EventHandler(this.toolStripMenuItemLogout_Click);
            this.toolStripMenuItemLogout.MouseLeave += new System.EventHandler(this.toolStripMenuItemQuit_MouseLeave);
            this.toolStripMenuItemLogout.MouseHover += new System.EventHandler(this.toolStripMenuItemQuit_MouseHover);
            // 
            // statusStripMainMenu
            // 
            this.statusStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelClient,
            this.toolStripStatusLabelMenuName});
            this.statusStripMainMenu.Location = new System.Drawing.Point(0, 708);
            this.statusStripMainMenu.Name = "statusStripMainMenu";
            this.statusStripMainMenu.Size = new System.Drawing.Size(1008, 22);
            this.statusStripMainMenu.TabIndex = 1;
            // 
            // toolStripStatusLabelClient
            // 
            this.toolStripStatusLabelClient.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelClient.Image")));
            this.toolStripStatusLabelClient.Name = "toolStripStatusLabelClient";
            this.toolStripStatusLabelClient.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabelClient.Text = "Munkaállomás: ";
            // 
            // toolStripStatusLabelMenuName
            // 
            this.toolStripStatusLabelMenuName.Name = "toolStripStatusLabelMenuName";
            this.toolStripStatusLabelMenuName.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBoxVRLogo
            // 
            this.pictureBoxVRLogo.Location = new System.Drawing.Point(12, 52);
            this.pictureBoxVRLogo.Name = "pictureBoxVRLogo";
            this.pictureBoxVRLogo.Size = new System.Drawing.Size(326, 450);
            this.pictureBoxVRLogo.TabIndex = 5;
            this.pictureBoxVRLogo.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // pictureBoxBSLogo
            // 
            this.pictureBoxBSLogo.Location = new System.Drawing.Point(12, 508);
            this.pictureBoxBSLogo.Name = "pictureBoxBSLogo";
            this.pictureBoxBSLogo.Size = new System.Drawing.Size(326, 197);
            this.pictureBoxBSLogo.TabIndex = 7;
            this.pictureBoxBSLogo.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pictureBoxBSLogo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBoxVRLogo);
            this.Controls.Add(this.statusStripMainMenu);
            this.Controls.Add(this.menuStripMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Receptionist | ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.statusStripMainMenu.ResumeLayout(false);
            this.statusStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBSLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.StatusStrip statusStripMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxVRLogo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRoomEditor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuestDatabase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBilling;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClient;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMenuName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelpCHM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAboutUs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccomodationData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBoxBSLogo;
    }
}