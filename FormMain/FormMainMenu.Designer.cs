
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
            this.panelUp = new System.Windows.Forms.Panel();
            this.labelmainMenu = new System.Windows.Forms.Label();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonMostPopular = new System.Windows.Forms.Button();
            this.buttonNewComing = new System.Windows.Forms.Button();
            this.buttonTovarLook = new System.Windows.Forms.Button();
            this.panelCentre = new System.Windows.Forms.Panel();
            this.panelDown = new System.Windows.Forms.Panel();
            this.labelChangeZakaz = new System.Windows.Forms.Label();
            this.buttonCgangeZakaz = new System.Windows.Forms.Button();
            this.buttonDoDelivery = new System.Windows.Forms.Button();
            this.panelUp.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelLeft.SuspendLayout();
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
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonMostPopular);
            this.panelLeft.Controls.Add(this.buttonNewComing);
            this.panelLeft.Controls.Add(this.buttonTovarLook);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 102);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(272, 492);
            this.panelLeft.TabIndex = 1;
            // 
            // buttonMostPopular
            // 
            this.buttonMostPopular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMostPopular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostPopular.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMostPopular.Location = new System.Drawing.Point(12, 216);
            this.buttonMostPopular.Name = "buttonMostPopular";
            this.buttonMostPopular.Size = new System.Drawing.Size(260, 94);
            this.buttonMostPopular.TabIndex = 2;
            this.buttonMostPopular.Text = "Самое Популярное";
            this.buttonMostPopular.UseVisualStyleBackColor = false;
            // 
            // buttonNewComing
            // 
            this.buttonNewComing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonNewComing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewComing.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewComing.Location = new System.Drawing.Point(12, 116);
            this.buttonNewComing.Name = "buttonNewComing";
            this.buttonNewComing.Size = new System.Drawing.Size(260, 94);
            this.buttonNewComing.TabIndex = 2;
            this.buttonNewComing.Text = "Новинки Сезона\r\n";
            this.buttonNewComing.UseVisualStyleBackColor = false;
            this.buttonNewComing.Click += new System.EventHandler(this.buttonNewComing_Click);
            // 
            // buttonTovarLook
            // 
            this.buttonTovarLook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonTovarLook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTovarLook.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovarLook.Location = new System.Drawing.Point(12, 16);
            this.buttonTovarLook.Name = "buttonTovarLook";
            this.buttonTovarLook.Size = new System.Drawing.Size(260, 94);
            this.buttonTovarLook.TabIndex = 2;
            this.buttonTovarLook.Text = "Посмотреть Ассортимент";
            this.buttonTovarLook.UseVisualStyleBackColor = false;
            this.buttonTovarLook.Click += new System.EventHandler(this.buttonTovarLook_Click);
            // 
            // panelCentre
            // 
            this.panelCentre.Controls.Add(this.panelDown);
            this.panelCentre.Controls.Add(this.buttonDoDelivery);
            this.panelCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre.Location = new System.Drawing.Point(272, 102);
            this.panelCentre.Name = "panelCentre";
            this.panelCentre.Size = new System.Drawing.Size(756, 492);
            this.panelCentre.TabIndex = 2;
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.labelChangeZakaz);
            this.panelDown.Controls.Add(this.buttonCgangeZakaz);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 332);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(756, 160);
            this.panelDown.TabIndex = 2;
            // 
            // labelChangeZakaz
            // 
            this.labelChangeZakaz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChangeZakaz.AutoSize = true;
            this.labelChangeZakaz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangeZakaz.Location = new System.Drawing.Point(89, 31);
            this.labelChangeZakaz.Name = "labelChangeZakaz";
            this.labelChangeZakaz.Size = new System.Drawing.Size(493, 60);
            this.labelChangeZakaz.TabIndex = 1;
            this.labelChangeZakaz.Text = "Если вы хотите внести \r\nкорректировки в свой заказ, вы можете";
            // 
            // buttonCgangeZakaz
            // 
            this.buttonCgangeZakaz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCgangeZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCgangeZakaz.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCgangeZakaz.Location = new System.Drawing.Point(439, 20);
            this.buttonCgangeZakaz.Name = "buttonCgangeZakaz";
            this.buttonCgangeZakaz.Size = new System.Drawing.Size(255, 107);
            this.buttonCgangeZakaz.TabIndex = 0;
            this.buttonCgangeZakaz.Text = "Изменить Заказ";
            this.buttonCgangeZakaz.UseVisualStyleBackColor = true;
            // 
            // buttonDoDelivery
            // 
            this.buttonDoDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonDoDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoDelivery.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoDelivery.Location = new System.Drawing.Point(94, 189);
            this.buttonDoDelivery.Name = "buttonDoDelivery";
            this.buttonDoDelivery.Size = new System.Drawing.Size(600, 120);
            this.buttonDoDelivery.TabIndex = 1;
            this.buttonDoDelivery.Text = "Сделать Заказ";
            this.buttonDoDelivery.UseVisualStyleBackColor = false;
            this.buttonDoDelivery.Click += new System.EventHandler(this.buttonDoDelivery_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1028, 594);
            this.Controls.Add(this.panelCentre);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelUp);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 460);
            this.Name = "FormMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelCentre.ResumeLayout(false);
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonTovarLook;
        private System.Windows.Forms.Panel panelCentre;
        private System.Windows.Forms.Button buttonNewComing;
        private System.Windows.Forms.Button buttonDoDelivery;
        private System.Windows.Forms.Button buttonAboutUs;
        private System.Windows.Forms.Button buttonMostPopular;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Label labelChangeZakaz;
        private System.Windows.Forms.Button buttonCgangeZakaz;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label labelmainMenu;
    }
}

