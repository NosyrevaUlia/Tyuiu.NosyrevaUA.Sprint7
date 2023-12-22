
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTovarLook));
            this.panelUp = new System.Windows.Forms.Panel();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelAssortiment = new System.Windows.Forms.Label();
            this.panelTovars = new System.Windows.Forms.Panel();
            this.labelSinSue = new System.Windows.Forms.Label();
            this.labelLumine = new System.Windows.Forms.Label();
            this.labelSucrose = new System.Windows.Forms.Label();
            this.labelDiluc = new System.Windows.Forms.Label();
            this.pictureBoxSinSue = new System.Windows.Forms.PictureBox();
            this.pictureBoxLumine = new System.Windows.Forms.PictureBox();
            this.pictureBoxSucrose = new System.Windows.Forms.PictureBox();
            this.pictureBoxDiluc = new System.Windows.Forms.PictureBox();
            this.textBoxDiluc = new System.Windows.Forms.TextBox();
            this.textBoxSucrose = new System.Windows.Forms.TextBox();
            this.textBoxLumine = new System.Windows.Forms.TextBox();
            this.textBoxSinSue = new System.Windows.Forms.TextBox();
            this.panelUp.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelTovars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSinSue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLumine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSucrose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiluc)).BeginInit();
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
            this.panelTovars.Controls.Add(this.textBoxSinSue);
            this.panelTovars.Controls.Add(this.textBoxLumine);
            this.panelTovars.Controls.Add(this.textBoxSucrose);
            this.panelTovars.Controls.Add(this.textBoxDiluc);
            this.panelTovars.Controls.Add(this.labelSinSue);
            this.panelTovars.Controls.Add(this.labelLumine);
            this.panelTovars.Controls.Add(this.labelSucrose);
            this.panelTovars.Controls.Add(this.labelDiluc);
            this.panelTovars.Controls.Add(this.pictureBoxSinSue);
            this.panelTovars.Controls.Add(this.pictureBoxLumine);
            this.panelTovars.Controls.Add(this.pictureBoxSucrose);
            this.panelTovars.Controls.Add(this.pictureBoxDiluc);
            this.panelTovars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTovars.Location = new System.Drawing.Point(0, 135);
            this.panelTovars.Name = "panelTovars";
            this.panelTovars.Size = new System.Drawing.Size(1028, 459);
            this.panelTovars.TabIndex = 1;
            // 
            // labelSinSue
            // 
            this.labelSinSue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSinSue.AutoSize = true;
            this.labelSinSue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinSue.Location = new System.Drawing.Point(759, 221);
            this.labelSinSue.Name = "labelSinSue";
            this.labelSinSue.Size = new System.Drawing.Size(351, 30);
            this.labelSinSue.TabIndex = 1;
            this.labelSinSue.Text = "Фигурка акриловая Син Сю";
            // 
            // labelLumine
            // 
            this.labelLumine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLumine.AutoSize = true;
            this.labelLumine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLumine.Location = new System.Drawing.Point(277, 224);
            this.labelLumine.Name = "labelLumine";
            this.labelLumine.Size = new System.Drawing.Size(342, 30);
            this.labelLumine.TabIndex = 1;
            this.labelLumine.Text = "Фигурка акриловая Люмин";
            // 
            // labelSucrose
            // 
            this.labelSucrose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSucrose.AutoSize = true;
            this.labelSucrose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSucrose.Location = new System.Drawing.Point(759, 3);
            this.labelSucrose.Name = "labelSucrose";
            this.labelSucrose.Size = new System.Drawing.Size(377, 30);
            this.labelSucrose.TabIndex = 1;
            this.labelSucrose.Text = "Фигурка акриловая Сахароза";
            // 
            // labelDiluc
            // 
            this.labelDiluc.AutoSize = true;
            this.labelDiluc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiluc.Location = new System.Drawing.Point(277, 7);
            this.labelDiluc.Name = "labelDiluc";
            this.labelDiluc.Size = new System.Drawing.Size(333, 30);
            this.labelDiluc.TabIndex = 1;
            this.labelDiluc.Text = "Фигурка акриловая Дилюк";
            // 
            // pictureBoxSinSue
            // 
            this.pictureBoxSinSue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSinSue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSinSue.Image")));
            this.pictureBoxSinSue.Location = new System.Drawing.Point(505, 224);
            this.pictureBoxSinSue.Name = "pictureBoxSinSue";
            this.pictureBoxSinSue.Size = new System.Drawing.Size(285, 223);
            this.pictureBoxSinSue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSinSue.TabIndex = 0;
            this.pictureBoxSinSue.TabStop = false;
            // 
            // pictureBoxLumine
            // 
            this.pictureBoxLumine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxLumine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLumine.Image")));
            this.pictureBoxLumine.Location = new System.Drawing.Point(4, 226);
            this.pictureBoxLumine.Name = "pictureBoxLumine";
            this.pictureBoxLumine.Size = new System.Drawing.Size(285, 221);
            this.pictureBoxLumine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLumine.TabIndex = 0;
            this.pictureBoxLumine.TabStop = false;
            // 
            // pictureBoxSucrose
            // 
            this.pictureBoxSucrose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSucrose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSucrose.Image")));
            this.pictureBoxSucrose.Location = new System.Drawing.Point(505, 3);
            this.pictureBoxSucrose.Name = "pictureBoxSucrose";
            this.pictureBoxSucrose.Size = new System.Drawing.Size(285, 215);
            this.pictureBoxSucrose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSucrose.TabIndex = 0;
            this.pictureBoxSucrose.TabStop = false;
            // 
            // pictureBoxDiluc
            // 
            this.pictureBoxDiluc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDiluc.Image")));
            this.pictureBoxDiluc.Location = new System.Drawing.Point(4, 7);
            this.pictureBoxDiluc.Name = "pictureBoxDiluc";
            this.pictureBoxDiluc.Size = new System.Drawing.Size(285, 211);
            this.pictureBoxDiluc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDiluc.TabIndex = 0;
            this.pictureBoxDiluc.TabStop = false;
            // 
            // textBoxDiluc
            // 
            this.textBoxDiluc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxDiluc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiluc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDiluc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxDiluc.Location = new System.Drawing.Point(282, 41);
            this.textBoxDiluc.Multiline = true;
            this.textBoxDiluc.Name = "textBoxDiluc";
            this.textBoxDiluc.ReadOnly = true;
            this.textBoxDiluc.Size = new System.Drawing.Size(100, 177);
            this.textBoxDiluc.TabIndex = 2;
            this.textBoxDiluc.Text = "Цена: \r\n1.600 руб.\r\n";
            // 
            // textBoxSucrose
            // 
            this.textBoxSucrose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSucrose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSucrose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSucrose.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSucrose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSucrose.Location = new System.Drawing.Point(764, 41);
            this.textBoxSucrose.Multiline = true;
            this.textBoxSucrose.Name = "textBoxSucrose";
            this.textBoxSucrose.ReadOnly = true;
            this.textBoxSucrose.Size = new System.Drawing.Size(100, 177);
            this.textBoxSucrose.TabIndex = 2;
            this.textBoxSucrose.Text = "Цена: \r\n1.600 руб.\r\n";
            // 
            // textBoxLumine
            // 
            this.textBoxLumine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLumine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxLumine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLumine.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLumine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxLumine.Location = new System.Drawing.Point(282, 270);
            this.textBoxLumine.Multiline = true;
            this.textBoxLumine.Name = "textBoxLumine";
            this.textBoxLumine.ReadOnly = true;
            this.textBoxLumine.Size = new System.Drawing.Size(100, 177);
            this.textBoxLumine.TabIndex = 2;
            this.textBoxLumine.Text = "Цена: \r\n1.800 руб.\r\n";
            // 
            // textBoxSinSue
            // 
            this.textBoxSinSue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSinSue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSinSue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSinSue.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSinSue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSinSue.Location = new System.Drawing.Point(764, 270);
            this.textBoxSinSue.Multiline = true;
            this.textBoxSinSue.Name = "textBoxSinSue";
            this.textBoxSinSue.ReadOnly = true;
            this.textBoxSinSue.Size = new System.Drawing.Size(100, 177);
            this.textBoxSinSue.TabIndex = 2;
            this.textBoxSinSue.Text = "Цена: \r\n1.600 руб.\r\n";
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
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "FormTovarLook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelTovars.ResumeLayout(false);
            this.panelTovars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSinSue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLumine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSucrose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiluc)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxSinSue;
        private System.Windows.Forms.PictureBox pictureBoxLumine;
        private System.Windows.Forms.PictureBox pictureBoxSucrose;
        private System.Windows.Forms.PictureBox pictureBoxDiluc;
        private System.Windows.Forms.Label labelSinSue;
        private System.Windows.Forms.Label labelLumine;
        private System.Windows.Forms.Label labelSucrose;
        private System.Windows.Forms.Label labelDiluc;
        private System.Windows.Forms.TextBox textBoxSinSue;
        private System.Windows.Forms.TextBox textBoxLumine;
        private System.Windows.Forms.TextBox textBoxSucrose;
        private System.Windows.Forms.TextBox textBoxDiluc;
    }
}