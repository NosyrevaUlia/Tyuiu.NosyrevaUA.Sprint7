﻿
namespace FormMain
{
    partial class FormTovarLook
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
            this.labelAssortiment = new System.Windows.Forms.Label();
            this.panelTovars = new System.Windows.Forms.Panel();
            this.pictureBoxSucrose = new System.Windows.Forms.PictureBox();
            this.pictureBoxDiluc = new System.Windows.Forms.PictureBox();
            this.pictureBoxLumine = new System.Windows.Forms.PictureBox();
            this.pictureBoxSinsue = new System.Windows.Forms.PictureBox();
            this.panelUp.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelTovars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSucrose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiluc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLumine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSinsue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.panelForButtons);
            this.panelUp.Controls.Add(this.buttonHome);
            this.panelUp.Controls.Add(this.labelAssortiment);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1028, 135);
            this.panelUp.TabIndex = 0;
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
            this.panelForButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForButtons_MouseDown);
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
            this.buttonHome.Location = new System.Drawing.Point(12, 59);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(110, 41);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "На Главную";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelAssortiment
            // 
            this.labelAssortiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelAssortiment.AutoSize = true;
            this.labelAssortiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAssortiment.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAssortiment.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelAssortiment.Location = new System.Drawing.Point(374, 59);
            this.labelAssortiment.Name = "labelAssortiment";
            this.labelAssortiment.Size = new System.Drawing.Size(416, 55);
            this.labelAssortiment.TabIndex = 0;
            this.labelAssortiment.Text = "Товары В Наличии";
            this.labelAssortiment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTovars
            // 
            this.panelTovars.Controls.Add(this.pictureBoxSucrose);
            this.panelTovars.Controls.Add(this.pictureBoxSinsue);
            this.panelTovars.Controls.Add(this.pictureBoxLumine);
            this.panelTovars.Controls.Add(this.pictureBoxDiluc);
            this.panelTovars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTovars.Location = new System.Drawing.Point(0, 135);
            this.panelTovars.Name = "panelTovars";
            this.panelTovars.Size = new System.Drawing.Size(1028, 459);
            this.panelTovars.TabIndex = 1;
            // 
            // pictureBoxSucrose
            // 
            this.pictureBoxSucrose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSucrose.Location = new System.Drawing.Point(494, 3);
            this.pictureBoxSucrose.Name = "pictureBoxSucrose";
            this.pictureBoxSucrose.Size = new System.Drawing.Size(334, 221);
            this.pictureBoxSucrose.TabIndex = 0;
            this.pictureBoxSucrose.TabStop = false;
            // 
            // pictureBoxDiluc
            // 
            this.pictureBoxDiluc.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxDiluc.Name = "pictureBoxDiluc";
            this.pictureBoxDiluc.Size = new System.Drawing.Size(334, 221);
            this.pictureBoxDiluc.TabIndex = 0;
            this.pictureBoxDiluc.TabStop = false;
            // 
            // pictureBoxLumine
            // 
            this.pictureBoxLumine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxLumine.Location = new System.Drawing.Point(0, 235);
            this.pictureBoxLumine.Name = "pictureBoxLumine";
            this.pictureBoxLumine.Size = new System.Drawing.Size(334, 221);
            this.pictureBoxLumine.TabIndex = 0;
            this.pictureBoxLumine.TabStop = false;
            // 
            // pictureBoxSinsue
            // 
            this.pictureBoxSinsue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSinsue.Location = new System.Drawing.Point(494, 235);
            this.pictureBoxSinsue.Name = "pictureBoxSinsue";
            this.pictureBoxSinsue.Size = new System.Drawing.Size(334, 221);
            this.pictureBoxSinsue.TabIndex = 0;
            this.pictureBoxSinsue.TabStop = false;
            // 
            // FormTovarLook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1028, 594);
            this.Controls.Add(this.panelTovars);
            this.Controls.Add(this.panelUp);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.MinimumSize = new System.Drawing.Size(900, 630);
            this.Name = "FormTovarLook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelTovars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSucrose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiluc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLumine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSinsue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Label labelAssortiment;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelTovars;
        private System.Windows.Forms.PictureBox pictureBoxSucrose;
        private System.Windows.Forms.PictureBox pictureBoxDiluc;
        private System.Windows.Forms.PictureBox pictureBoxSinsue;
        private System.Windows.Forms.PictureBox pictureBoxLumine;
    }
}