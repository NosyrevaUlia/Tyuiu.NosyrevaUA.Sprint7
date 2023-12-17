﻿
namespace FormMain
{
    partial class FormDoZakaz
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
            this.panelUp = new System.Windows.Forms.Panel();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelZakaz = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxYourNamePlease = new System.Windows.Forms.TextBox();
            this.textBoxYourName = new System.Windows.Forms.TextBox();
            this.textBoxAdressPlease = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxYouNumberPlease = new System.Windows.Forms.TextBox();
            this.textBoxYourNumber = new System.Windows.Forms.TextBox();
            this.panelUp.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.panelForButtons);
            this.panelUp.Controls.Add(this.buttonHome);
            this.panelUp.Controls.Add(this.labelZakaz);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1028, 135);
            this.panelUp.TabIndex = 1;
            // 
            // panelForButtons
            // 
            this.panelForButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panelForButtons.Controls.Add(this.buttonMinimize);
            this.panelForButtons.Controls.Add(this.buttonMaximize);
            this.panelForButtons.Controls.Add(this.buttonClose);
            this.panelForButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForButtons.Location = new System.Drawing.Point(0, 0);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(1028, 45);
            this.panelForButtons.TabIndex = 3;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMinimize.Location = new System.Drawing.Point(842, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(54, 29);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMaximize.Location = new System.Drawing.Point(902, 12);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(54, 29);
            this.buttonMaximize.TabIndex = 1;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonClose.Location = new System.Drawing.Point(962, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(54, 29);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonHome.Location = new System.Drawing.Point(12, 59);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(110, 41);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "На Главную";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelZakaz
            // 
            this.labelZakaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelZakaz.AutoSize = true;
            this.labelZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelZakaz.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZakaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelZakaz.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelZakaz.Location = new System.Drawing.Point(486, 59);
            this.labelZakaz.Name = "labelZakaz";
            this.labelZakaz.Size = new System.Drawing.Size(151, 55);
            this.labelZakaz.TabIndex = 0;
            this.labelZakaz.Text = "Заказ";
            this.labelZakaz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.textBoxYourNumber);
            this.panelRight.Controls.Add(this.textBoxAdress);
            this.panelRight.Controls.Add(this.textBoxYourName);
            this.panelRight.Controls.Add(this.textBoxYouNumberPlease);
            this.panelRight.Controls.Add(this.textBoxAdressPlease);
            this.panelRight.Controls.Add(this.textBoxYourNamePlease);
            this.panelRight.Controls.Add(this.labelDescription);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(0, 135);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(588, 459);
            this.panelRight.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelDescription.Location = new System.Drawing.Point(13, 7);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(787, 34);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Пожалуйста, введите данные для оформления заказа:";
            // 
            // textBoxYourNamePlease
            // 
            this.textBoxYourNamePlease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxYourNamePlease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYourNamePlease.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYourNamePlease.Location = new System.Drawing.Point(19, 74);
            this.textBoxYourNamePlease.Name = "textBoxYourNamePlease";
            this.textBoxYourNamePlease.ReadOnly = true;
            this.textBoxYourNamePlease.Size = new System.Drawing.Size(62, 27);
            this.textBoxYourNamePlease.TabIndex = 1;
            this.textBoxYourNamePlease.Text = "ФИО:";
            // 
            // textBoxYourName
            // 
            this.textBoxYourName.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxYourName.Location = new System.Drawing.Point(19, 103);
            this.textBoxYourName.Name = "textBoxYourName";
            this.textBoxYourName.Size = new System.Drawing.Size(372, 30);
            this.textBoxYourName.TabIndex = 2;
            // 
            // textBoxAdressPlease
            // 
            this.textBoxAdressPlease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxAdressPlease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdressPlease.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdressPlease.Location = new System.Drawing.Point(19, 170);
            this.textBoxAdressPlease.Name = "textBoxAdressPlease";
            this.textBoxAdressPlease.ReadOnly = true;
            this.textBoxAdressPlease.Size = new System.Drawing.Size(186, 27);
            this.textBoxAdressPlease.TabIndex = 1;
            this.textBoxAdressPlease.Text = "Адрес доставки:";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAdress.Location = new System.Drawing.Point(19, 199);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(372, 30);
            this.textBoxAdress.TabIndex = 2;
            // 
            // textBoxYouNumberPlease
            // 
            this.textBoxYouNumberPlease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxYouNumberPlease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYouNumberPlease.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYouNumberPlease.Location = new System.Drawing.Point(19, 268);
            this.textBoxYouNumberPlease.Name = "textBoxYouNumberPlease";
            this.textBoxYouNumberPlease.ReadOnly = true;
            this.textBoxYouNumberPlease.Size = new System.Drawing.Size(355, 27);
            this.textBoxYouNumberPlease.TabIndex = 1;
            this.textBoxYouNumberPlease.Text = "Контактный телефон заказчика:";
            // 
            // textBoxYourNumber
            // 
            this.textBoxYourNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxYourNumber.Location = new System.Drawing.Point(19, 297);
            this.textBoxYourNumber.Name = "textBoxYourNumber";
            this.textBoxYourNumber.Size = new System.Drawing.Size(372, 30);
            this.textBoxYourNumber.TabIndex = 2;
            // 
            // FormDoZakaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1028, 594);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelUp);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 460);
            this.Name = "FormDoZakaz";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelZakaz;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxYourNamePlease;
        private System.Windows.Forms.TextBox textBoxYourNumber;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxYourName;
        private System.Windows.Forms.TextBox textBoxYouNumberPlease;
        private System.Windows.Forms.TextBox textBoxAdressPlease;
    }
}