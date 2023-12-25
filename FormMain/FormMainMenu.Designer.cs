
namespace FormMain
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
            this.panelUp = new System.Windows.Forms.Panel();
            this.labelmainMenu = new System.Windows.Forms.Label();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.panelCentre = new System.Windows.Forms.Panel();
            this.panelDown = new System.Windows.Forms.Panel();
            this.buttonDoDelivery = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelUp.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelCentre.SuspendLayout();
            this.panelDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.labelmainMenu);
            this.panelUp.Controls.Add(this.panelForButtons);
            this.panelUp.Controls.Add(this.buttonAboutUs);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1028, 102);
            this.panelUp.TabIndex = 0;
            // 
            // labelmainMenu
            // 
            this.labelmainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelmainMenu.AutoSize = true;
            this.labelmainMenu.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmainMenu.Location = new System.Drawing.Point(414, 53);
            this.labelmainMenu.Name = "labelmainMenu";
            this.labelmainMenu.Size = new System.Drawing.Size(378, 58);
            this.labelmainMenu.TabIndex = 2;
            this.labelmainMenu.Text = "Главное Меню";
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
            this.panelForButtons.TabIndex = 1;
            this.panelForButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForButtons_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
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
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
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
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(962, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(54, 29);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAboutUs
            // 
            this.buttonAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutUs.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAboutUs.Location = new System.Drawing.Point(12, 51);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Size = new System.Drawing.Size(110, 41);
            this.buttonAboutUs.TabIndex = 0;
            this.buttonAboutUs.Text = "О Нас";
            this.buttonAboutUs.UseVisualStyleBackColor = false;
            this.buttonAboutUs.Click += new System.EventHandler(this.buttonAboutUs_Click);
            // 
            // panelCentre
            // 
            this.panelCentre.Controls.Add(this.panelDown);
            this.panelCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre.Location = new System.Drawing.Point(0, 102);
            this.panelCentre.Name = "panelCentre";
            this.panelCentre.Size = new System.Drawing.Size(1028, 492);
            this.panelCentre.TabIndex = 2;
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.textBox1);
            this.panelDown.Controls.Add(this.buttonDoDelivery);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDown.Location = new System.Drawing.Point(0, 0);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1028, 492);
            this.panelDown.TabIndex = 2;
            // 
            // buttonDoDelivery
            // 
            this.buttonDoDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonDoDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoDelivery.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoDelivery.Location = new System.Drawing.Point(96, 332);
            this.buttonDoDelivery.Name = "buttonDoDelivery";
            this.buttonDoDelivery.Size = new System.Drawing.Size(841, 109);
            this.buttonDoDelivery.TabIndex = 1;
            this.buttonDoDelivery.Text = "Сделать Заказ";
            this.buttonDoDelivery.UseVisualStyleBackColor = false;
            this.buttonDoDelivery.Click += new System.EventHandler(this.buttonDoDelivery_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBox1.Location = new System.Drawing.Point(96, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(841, 111);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Добро пожаловать! Здесь вы можете заказать акриловую фигурку.";
            // 
            // FormMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1028, 594);
            this.Controls.Add(this.panelCentre);
            this.Controls.Add(this.panelUp);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.MinimumSize = new System.Drawing.Size(1000, 460);
            this.Name = "FormMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelCentre.ResumeLayout(false);
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelCentre;
        private System.Windows.Forms.Button buttonDoDelivery;
        private System.Windows.Forms.Button buttonAboutUs;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label labelmainMenu;
        private System.Windows.Forms.TextBox textBox1;
    }
}

