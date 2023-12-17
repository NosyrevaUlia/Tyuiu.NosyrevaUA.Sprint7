
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxYourNameFirstPlease = new System.Windows.Forms.TextBox();
            this.textBoxYourNameFirst = new System.Windows.Forms.TextBox();
            this.textBoxAdressPlease = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxYouNumberPlease = new System.Windows.Forms.TextBox();
            this.textBoxYourNumber = new System.Windows.Forms.TextBox();
            this.textBoxDataDostavkiPlease = new System.Windows.Forms.TextBox();
            this.textBoxDataDostavki = new System.Windows.Forms.TextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.splitterLeftRight = new System.Windows.Forms.Splitter();
            this.buttonDoZAKAZ = new System.Windows.Forms.Button();
            this.textBoxYourNameSecond = new System.Windows.Forms.TextBox();
            this.textBoxYourNameThird = new System.Windows.Forms.TextBox();
            this.textBoxYourNameSecondPlease = new System.Windows.Forms.TextBox();
            this.textBoxYourNameThirdPlease = new System.Windows.Forms.TextBox();
            this.panelUp.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelLeft.SuspendLayout();
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
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.textBoxDataDostavki);
            this.panelLeft.Controls.Add(this.textBoxYourNumber);
            this.panelLeft.Controls.Add(this.textBoxAdress);
            this.panelLeft.Controls.Add(this.textBoxYourNameThird);
            this.panelLeft.Controls.Add(this.textBoxYourNameSecond);
            this.panelLeft.Controls.Add(this.textBoxYourNameFirst);
            this.panelLeft.Controls.Add(this.textBoxDataDostavkiPlease);
            this.panelLeft.Controls.Add(this.textBoxYouNumberPlease);
            this.panelLeft.Controls.Add(this.textBoxAdressPlease);
            this.panelLeft.Controls.Add(this.textBoxYourNameThirdPlease);
            this.panelLeft.Controls.Add(this.textBoxYourNameSecondPlease);
            this.panelLeft.Controls.Add(this.textBoxYourNameFirstPlease);
            this.panelLeft.Controls.Add(this.labelDescription);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 135);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(588, 459);
            this.panelLeft.TabIndex = 2;
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
            // textBoxYourNameFirstPlease
            // 
            this.textBoxYourNameFirstPlease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxYourNameFirstPlease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYourNameFirstPlease.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYourNameFirstPlease.Location = new System.Drawing.Point(19, 74);
            this.textBoxYourNameFirstPlease.Name = "textBoxYourNameFirstPlease";
            this.textBoxYourNameFirstPlease.ReadOnly = true;
            this.textBoxYourNameFirstPlease.Size = new System.Drawing.Size(186, 27);
            this.textBoxYourNameFirstPlease.TabIndex = 1;
            this.textBoxYourNameFirstPlease.Text = "Фамилия:";
            // 
            // textBoxYourNameFirst
            // 
            this.textBoxYourNameFirst.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxYourNameFirst.Location = new System.Drawing.Point(19, 103);
            this.textBoxYourNameFirst.Name = "textBoxYourNameFirst";
            this.textBoxYourNameFirst.Size = new System.Drawing.Size(186, 30);
            this.textBoxYourNameFirst.TabIndex = 2;
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
            // textBoxDataDostavkiPlease
            // 
            this.textBoxDataDostavkiPlease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxDataDostavkiPlease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDataDostavkiPlease.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDataDostavkiPlease.Location = new System.Drawing.Point(19, 363);
            this.textBoxDataDostavkiPlease.Name = "textBoxDataDostavkiPlease";
            this.textBoxDataDostavkiPlease.ReadOnly = true;
            this.textBoxDataDostavkiPlease.Size = new System.Drawing.Size(169, 27);
            this.textBoxDataDostavkiPlease.TabIndex = 1;
            this.textBoxDataDostavkiPlease.Text = "Дата доставки:";
            // 
            // textBoxDataDostavki
            // 
            this.textBoxDataDostavki.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDataDostavki.Location = new System.Drawing.Point(19, 396);
            this.textBoxDataDostavki.Name = "textBoxDataDostavki";
            this.textBoxDataDostavki.Size = new System.Drawing.Size(372, 30);
            this.textBoxDataDostavki.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.buttonDoZAKAZ);
            this.panelRight.Controls.Add(this.splitterLeftRight);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(588, 135);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(440, 459);
            this.panelRight.TabIndex = 3;
            // 
            // splitterLeftRight
            // 
            this.splitterLeftRight.Location = new System.Drawing.Point(0, 0);
            this.splitterLeftRight.Name = "splitterLeftRight";
            this.splitterLeftRight.Size = new System.Drawing.Size(3, 459);
            this.splitterLeftRight.TabIndex = 0;
            this.splitterLeftRight.TabStop = false;
            // 
            // buttonDoZAKAZ
            // 
            this.buttonDoZAKAZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoZAKAZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonDoZAKAZ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoZAKAZ.Location = new System.Drawing.Point(167, 363);
            this.buttonDoZAKAZ.Name = "buttonDoZAKAZ";
            this.buttonDoZAKAZ.Size = new System.Drawing.Size(242, 63);
            this.buttonDoZAKAZ.TabIndex = 1;
            this.buttonDoZAKAZ.Text = "Отправить Заказ";
            this.buttonDoZAKAZ.UseVisualStyleBackColor = false;
            this.buttonDoZAKAZ.Click += new System.EventHandler(this.buttonDoZAKAZ_Click);
            // 
            // textBoxYourNameSecond
            // 
            this.textBoxYourNameSecond.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxYourNameSecond.Location = new System.Drawing.Point(211, 103);
            this.textBoxYourNameSecond.Name = "textBoxYourNameSecond";
            this.textBoxYourNameSecond.Size = new System.Drawing.Size(186, 30);
            this.textBoxYourNameSecond.TabIndex = 2;
            // 
            // textBoxYourNameThird
            // 
            this.textBoxYourNameThird.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxYourNameThird.Location = new System.Drawing.Point(405, 103);
            this.textBoxYourNameThird.Name = "textBoxYourNameThird";
            this.textBoxYourNameThird.Size = new System.Drawing.Size(186, 30);
            this.textBoxYourNameThird.TabIndex = 2;
            // 
            // textBoxYourNameSecondPlease
            // 
            this.textBoxYourNameSecondPlease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxYourNameSecondPlease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYourNameSecondPlease.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYourNameSecondPlease.Location = new System.Drawing.Point(211, 74);
            this.textBoxYourNameSecondPlease.Name = "textBoxYourNameSecondPlease";
            this.textBoxYourNameSecondPlease.ReadOnly = true;
            this.textBoxYourNameSecondPlease.Size = new System.Drawing.Size(186, 27);
            this.textBoxYourNameSecondPlease.TabIndex = 1;
            this.textBoxYourNameSecondPlease.Text = "Имя:";
            // 
            // textBoxYourNameThirdPlease
            // 
            this.textBoxYourNameThirdPlease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxYourNameThirdPlease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYourNameThirdPlease.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYourNameThirdPlease.Location = new System.Drawing.Point(405, 74);
            this.textBoxYourNameThirdPlease.Name = "textBoxYourNameThirdPlease";
            this.textBoxYourNameThirdPlease.ReadOnly = true;
            this.textBoxYourNameThirdPlease.Size = new System.Drawing.Size(183, 27);
            this.textBoxYourNameThirdPlease.TabIndex = 1;
            this.textBoxYourNameThirdPlease.Text = "Отчество:";
            // 
            // FormDoZakaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1028, 594);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
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
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxYourNameFirstPlease;
        private System.Windows.Forms.TextBox textBoxYourNumber;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxYourNameFirst;
        private System.Windows.Forms.TextBox textBoxYouNumberPlease;
        private System.Windows.Forms.TextBox textBoxAdressPlease;
        private System.Windows.Forms.TextBox textBoxDataDostavki;
        private System.Windows.Forms.TextBox textBoxDataDostavkiPlease;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Splitter splitterLeftRight;
        private System.Windows.Forms.Button buttonDoZAKAZ;
        private System.Windows.Forms.TextBox textBoxYourNameThird;
        private System.Windows.Forms.TextBox textBoxYourNameSecond;
        private System.Windows.Forms.TextBox textBoxYourNameThirdPlease;
        private System.Windows.Forms.TextBox textBoxYourNameSecondPlease;
    }
}