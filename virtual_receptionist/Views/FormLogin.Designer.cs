﻿namespace virtual_receptionist.View
{
    partial class FormLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxAccomodationID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelAccomodationID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConnectTo = new System.Windows.Forms.Label();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(198, 101);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(214, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Belépés";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonLogin_KeyUp);
            // 
            // textBoxAccomodationID
            // 
            this.textBoxAccomodationID.Location = new System.Drawing.Point(198, 22);
            this.textBoxAccomodationID.Name = "textBoxAccomodationID";
            this.textBoxAccomodationID.Size = new System.Drawing.Size(214, 20);
            this.textBoxAccomodationID.TabIndex = 0;
            this.textBoxAccomodationID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAccomodationID_KeyUp);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(198, 48);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(214, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyUp);
            // 
            // labelAccomodationID
            // 
            this.labelAccomodationID.AutoSize = true;
            this.labelAccomodationID.Location = new System.Drawing.Point(80, 25);
            this.labelAccomodationID.Name = "labelAccomodationID";
            this.labelAccomodationID.Size = new System.Drawing.Size(112, 13);
            this.labelAccomodationID.TabIndex = 4;
            this.labelAccomodationID.Text = "Szálláshely azonosító:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(153, 51);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(39, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Jelszó:";
            // 
            // labelConnectTo
            // 
            this.labelConnectTo.AutoSize = true;
            this.labelConnectTo.Location = new System.Drawing.Point(59, 77);
            this.labelConnectTo.Name = "labelConnectTo";
            this.labelConnectTo.Size = new System.Drawing.Size(133, 13);
            this.labelConnectTo.TabIndex = 6;
            this.labelConnectTo.Text = "Csatlakozás kiszolgálóhoz:";
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.FormattingEnabled = true;
            this.comboBoxConnectionType.Items.AddRange(new object[] {
            "otthoni",
            "iskolai"});
            this.comboBoxConnectionType.Location = new System.Drawing.Point(198, 74);
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.Size = new System.Drawing.Size(214, 21);
            this.comboBoxConnectionType.TabIndex = 3;
            this.comboBoxConnectionType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxConnectionType_KeyUp);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.comboBoxConnectionType);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.labelConnectTo);
            this.groupBoxLogin.Controls.Add(this.textBoxAccomodationID);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.labelAccomodationID);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(514, 146);
            this.groupBoxLogin.TabIndex = 11;
            this.groupBoxLogin.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 170);
            this.Controls.Add(this.groupBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfiguráció | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxAccomodationID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelAccomodationID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConnectTo;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.GroupBox groupBoxLogin;
    }
}

