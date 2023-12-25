
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
            this.buttonConfirmBuying = new System.Windows.Forms.Button();
            this.labelYourBucked = new System.Windows.Forms.Label();
            this.buttonBucket = new System.Windows.Forms.Button();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelAssortiment = new System.Windows.Forms.Label();
            this.panelTovars = new System.Windows.Forms.Panel();
            this.textBoxBucked = new System.Windows.Forms.TextBox();
            this.textBoxSinSueKolichestvo = new System.Windows.Forms.TextBox();
            this.textBoxLumineKolichestvo = new System.Windows.Forms.TextBox();
            this.textBoxSucroseKolichestvo = new System.Windows.Forms.TextBox();
            this.textBoxDilucKolichestvo = new System.Windows.Forms.TextBox();
            this.labelSinSueInBucked = new System.Windows.Forms.Label();
            this.labelLumineInBucked = new System.Windows.Forms.Label();
            this.labelSucroseInBucked = new System.Windows.Forms.Label();
            this.labelDilucInBucked = new System.Windows.Forms.Label();
            this.textBoxSinSueCost = new System.Windows.Forms.TextBox();
            this.textBoxLumineCost = new System.Windows.Forms.TextBox();
            this.textBoxSucroseCost = new System.Windows.Forms.TextBox();
            this.textBoxDilucCost = new System.Windows.Forms.TextBox();
            this.buttonSinSueToBucket = new System.Windows.Forms.Button();
            this.buttonLumineToBucket = new System.Windows.Forms.Button();
            this.buttonSucroseToBucket = new System.Windows.Forms.Button();
            this.buttonDilucToBucket = new System.Windows.Forms.Button();
            this.textBoxSinSue = new System.Windows.Forms.TextBox();
            this.textBoxLumine = new System.Windows.Forms.TextBox();
            this.textBoxSucrose = new System.Windows.Forms.TextBox();
            this.textBoxDiluc = new System.Windows.Forms.TextBox();
            this.labelSinSue = new System.Windows.Forms.Label();
            this.labelLumine = new System.Windows.Forms.Label();
            this.labelSucrose = new System.Windows.Forms.Label();
            this.labelDiluc = new System.Windows.Forms.Label();
            this.pictureBoxSinSue = new System.Windows.Forms.PictureBox();
            this.pictureBoxLumine = new System.Windows.Forms.PictureBox();
            this.pictureBoxSucrose = new System.Windows.Forms.PictureBox();
            this.pictureBoxDiluc = new System.Windows.Forms.PictureBox();
            this.buttonMinDiluc = new System.Windows.Forms.Button();
            this.buttonMinSucrose = new System.Windows.Forms.Button();
            this.buttonMinSinSue = new System.Windows.Forms.Button();
            this.buttonMinLumine = new System.Windows.Forms.Button();
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
            this.panelUp.Controls.Add(this.buttonConfirmBuying);
            this.panelUp.Controls.Add(this.labelYourBucked);
            this.panelUp.Controls.Add(this.buttonBucket);
            this.panelUp.Controls.Add(this.panelForButtons);
            this.panelUp.Controls.Add(this.buttonHome);
            this.panelUp.Controls.Add(this.labelAssortiment);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1028, 135);
            this.panelUp.TabIndex = 0;
            // 
            // buttonConfirmBuying
            // 
            this.buttonConfirmBuying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmBuying.Enabled = false;
            this.buttonConfirmBuying.Location = new System.Drawing.Point(786, 59);
            this.buttonConfirmBuying.Name = "buttonConfirmBuying";
            this.buttonConfirmBuying.Size = new System.Drawing.Size(110, 70);
            this.buttonConfirmBuying.TabIndex = 6;
            this.buttonConfirmBuying.Text = "Подтвердить выбор";
            this.buttonConfirmBuying.UseVisualStyleBackColor = true;
            this.buttonConfirmBuying.Click += new System.EventHandler(this.buttonConfirmBuying_Click);
            // 
            // labelYourBucked
            // 
            this.labelYourBucked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelYourBucked.AutoSize = true;
            this.labelYourBucked.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYourBucked.Location = new System.Drawing.Point(388, 59);
            this.labelYourBucked.Name = "labelYourBucked";
            this.labelYourBucked.Size = new System.Drawing.Size(350, 55);
            this.labelYourBucked.TabIndex = 5;
            this.labelYourBucked.Text = "Ваша Корзина";
            this.labelYourBucked.Visible = false;
            // 
            // buttonBucket
            // 
            this.buttonBucket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBucket.Location = new System.Drawing.Point(902, 59);
            this.buttonBucket.Name = "buttonBucket";
            this.buttonBucket.Size = new System.Drawing.Size(117, 70);
            this.buttonBucket.TabIndex = 4;
            this.buttonBucket.Text = "Корзина";
            this.buttonBucket.UseVisualStyleBackColor = true;
            this.buttonBucket.Click += new System.EventHandler(this.buttonBucket_Click);
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
            this.panelTovars.Controls.Add(this.textBoxBucked);
            this.panelTovars.Controls.Add(this.textBoxSinSueKolichestvo);
            this.panelTovars.Controls.Add(this.textBoxLumineKolichestvo);
            this.panelTovars.Controls.Add(this.textBoxSucroseKolichestvo);
            this.panelTovars.Controls.Add(this.textBoxDilucKolichestvo);
            this.panelTovars.Controls.Add(this.labelSinSueInBucked);
            this.panelTovars.Controls.Add(this.labelLumineInBucked);
            this.panelTovars.Controls.Add(this.labelSucroseInBucked);
            this.panelTovars.Controls.Add(this.labelDilucInBucked);
            this.panelTovars.Controls.Add(this.textBoxSinSueCost);
            this.panelTovars.Controls.Add(this.textBoxLumineCost);
            this.panelTovars.Controls.Add(this.textBoxSucroseCost);
            this.panelTovars.Controls.Add(this.textBoxDilucCost);
            this.panelTovars.Controls.Add(this.buttonSinSueToBucket);
            this.panelTovars.Controls.Add(this.buttonLumineToBucket);
            this.panelTovars.Controls.Add(this.buttonSucroseToBucket);
            this.panelTovars.Controls.Add(this.buttonDilucToBucket);
            this.panelTovars.Controls.Add(this.labelLumine);
            this.panelTovars.Controls.Add(this.labelSucrose);
            this.panelTovars.Controls.Add(this.labelDiluc);
            this.panelTovars.Controls.Add(this.buttonMinDiluc);
            this.panelTovars.Controls.Add(this.buttonMinSucrose);
            this.panelTovars.Controls.Add(this.buttonMinSinSue);
            this.panelTovars.Controls.Add(this.buttonMinLumine);
            this.panelTovars.Controls.Add(this.textBoxDiluc);
            this.panelTovars.Controls.Add(this.textBoxSucrose);
            this.panelTovars.Controls.Add(this.textBoxSinSue);
            this.panelTovars.Controls.Add(this.textBoxLumine);
            this.panelTovars.Controls.Add(this.pictureBoxLumine);
            this.panelTovars.Controls.Add(this.pictureBoxDiluc);
            this.panelTovars.Controls.Add(this.labelSinSue);
            this.panelTovars.Controls.Add(this.pictureBoxSinSue);
            this.panelTovars.Controls.Add(this.pictureBoxSucrose);
            this.panelTovars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTovars.Location = new System.Drawing.Point(0, 135);
            this.panelTovars.Name = "panelTovars";
            this.panelTovars.Size = new System.Drawing.Size(1028, 459);
            this.panelTovars.TabIndex = 1;
            // 
            // textBoxBucked
            // 
            this.textBoxBucked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBucked.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBucked.Location = new System.Drawing.Point(0, 0);
            this.textBoxBucked.Multiline = true;
            this.textBoxBucked.Name = "textBoxBucked";
            this.textBoxBucked.ReadOnly = true;
            this.textBoxBucked.Size = new System.Drawing.Size(1028, 459);
            this.textBoxBucked.TabIndex = 7;
            this.textBoxBucked.Visible = false;
            // 
            // textBoxSinSueKolichestvo
            // 
            this.textBoxSinSueKolichestvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSinSueKolichestvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSinSueKolichestvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSinSueKolichestvo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSinSueKolichestvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSinSueKolichestvo.Location = new System.Drawing.Point(842, 345);
            this.textBoxSinSueKolichestvo.Name = "textBoxSinSueKolichestvo";
            this.textBoxSinSueKolichestvo.ReadOnly = true;
            this.textBoxSinSueKolichestvo.Size = new System.Drawing.Size(73, 25);
            this.textBoxSinSueKolichestvo.TabIndex = 6;
            this.textBoxSinSueKolichestvo.Text = "0";
            // 
            // textBoxLumineKolichestvo
            // 
            this.textBoxLumineKolichestvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLumineKolichestvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxLumineKolichestvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLumineKolichestvo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLumineKolichestvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxLumineKolichestvo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxLumineKolichestvo.Location = new System.Drawing.Point(331, 344);
            this.textBoxLumineKolichestvo.Name = "textBoxLumineKolichestvo";
            this.textBoxLumineKolichestvo.ReadOnly = true;
            this.textBoxLumineKolichestvo.Size = new System.Drawing.Size(73, 25);
            this.textBoxLumineKolichestvo.TabIndex = 6;
            this.textBoxLumineKolichestvo.Text = "0";
            // 
            // textBoxSucroseKolichestvo
            // 
            this.textBoxSucroseKolichestvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSucroseKolichestvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSucroseKolichestvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSucroseKolichestvo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSucroseKolichestvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSucroseKolichestvo.Location = new System.Drawing.Point(842, 126);
            this.textBoxSucroseKolichestvo.Name = "textBoxSucroseKolichestvo";
            this.textBoxSucroseKolichestvo.ReadOnly = true;
            this.textBoxSucroseKolichestvo.Size = new System.Drawing.Size(73, 25);
            this.textBoxSucroseKolichestvo.TabIndex = 6;
            this.textBoxSucroseKolichestvo.Text = "0";
            // 
            // textBoxDilucKolichestvo
            // 
            this.textBoxDilucKolichestvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxDilucKolichestvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDilucKolichestvo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDilucKolichestvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxDilucKolichestvo.Location = new System.Drawing.Point(342, 126);
            this.textBoxDilucKolichestvo.Name = "textBoxDilucKolichestvo";
            this.textBoxDilucKolichestvo.ReadOnly = true;
            this.textBoxDilucKolichestvo.Size = new System.Drawing.Size(73, 25);
            this.textBoxDilucKolichestvo.TabIndex = 6;
            this.textBoxDilucKolichestvo.Text = "0";
            // 
            // labelSinSueInBucked
            // 
            this.labelSinSueInBucked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSinSueInBucked.AutoSize = true;
            this.labelSinSueInBucked.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinSueInBucked.Location = new System.Drawing.Point(729, 342);
            this.labelSinSueInBucked.Name = "labelSinSueInBucked";
            this.labelSinSueInBucked.Size = new System.Drawing.Size(116, 23);
            this.labelSinSueInBucked.TabIndex = 5;
            this.labelSinSueInBucked.Text = "В Корзине:";
            // 
            // labelLumineInBucked
            // 
            this.labelLumineInBucked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLumineInBucked.AutoSize = true;
            this.labelLumineInBucked.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLumineInBucked.Location = new System.Drawing.Point(220, 342);
            this.labelLumineInBucked.Name = "labelLumineInBucked";
            this.labelLumineInBucked.Size = new System.Drawing.Size(116, 23);
            this.labelLumineInBucked.TabIndex = 5;
            this.labelLumineInBucked.Text = "В Корзине:";
            // 
            // labelSucroseInBucked
            // 
            this.labelSucroseInBucked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSucroseInBucked.AutoSize = true;
            this.labelSucroseInBucked.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSucroseInBucked.Location = new System.Drawing.Point(729, 123);
            this.labelSucroseInBucked.Name = "labelSucroseInBucked";
            this.labelSucroseInBucked.Size = new System.Drawing.Size(116, 23);
            this.labelSucroseInBucked.TabIndex = 5;
            this.labelSucroseInBucked.Text = "В Корзине:";
            // 
            // labelDilucInBucked
            // 
            this.labelDilucInBucked.AutoSize = true;
            this.labelDilucInBucked.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDilucInBucked.Location = new System.Drawing.Point(220, 123);
            this.labelDilucInBucked.Name = "labelDilucInBucked";
            this.labelDilucInBucked.Size = new System.Drawing.Size(116, 23);
            this.labelDilucInBucked.TabIndex = 5;
            this.labelDilucInBucked.Text = "В Корзине:";
            // 
            // textBoxSinSueCost
            // 
            this.textBoxSinSueCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSinSueCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSinSueCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSinSueCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSinSueCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSinSueCost.Location = new System.Drawing.Point(863, 261);
            this.textBoxSinSueCost.Name = "textBoxSinSueCost";
            this.textBoxSinSueCost.ReadOnly = true;
            this.textBoxSinSueCost.Size = new System.Drawing.Size(100, 30);
            this.textBoxSinSueCost.TabIndex = 4;
            this.textBoxSinSueCost.Text = "1600";
            // 
            // textBoxLumineCost
            // 
            this.textBoxLumineCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLumineCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxLumineCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLumineCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLumineCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxLumineCost.Location = new System.Drawing.Point(362, 261);
            this.textBoxLumineCost.Name = "textBoxLumineCost";
            this.textBoxLumineCost.ReadOnly = true;
            this.textBoxLumineCost.Size = new System.Drawing.Size(100, 30);
            this.textBoxLumineCost.TabIndex = 4;
            this.textBoxLumineCost.Text = "1800";
            // 
            // textBoxSucroseCost
            // 
            this.textBoxSucroseCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSucroseCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSucroseCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSucroseCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSucroseCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSucroseCost.Location = new System.Drawing.Point(863, 41);
            this.textBoxSucroseCost.Name = "textBoxSucroseCost";
            this.textBoxSucroseCost.ReadOnly = true;
            this.textBoxSucroseCost.Size = new System.Drawing.Size(100, 30);
            this.textBoxSucroseCost.TabIndex = 4;
            this.textBoxSucroseCost.Text = "1600";
            // 
            // textBoxDilucCost
            // 
            this.textBoxDilucCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxDilucCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDilucCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDilucCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxDilucCost.Location = new System.Drawing.Point(362, 41);
            this.textBoxDilucCost.Name = "textBoxDilucCost";
            this.textBoxDilucCost.ReadOnly = true;
            this.textBoxDilucCost.Size = new System.Drawing.Size(100, 30);
            this.textBoxDilucCost.TabIndex = 4;
            this.textBoxDilucCost.Text = "1600";
            // 
            // buttonSinSueToBucket
            // 
            this.buttonSinSueToBucket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSinSueToBucket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSinSueToBucket.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSinSueToBucket.Location = new System.Drawing.Point(723, 302);
            this.buttonSinSueToBucket.Name = "buttonSinSueToBucket";
            this.buttonSinSueToBucket.Size = new System.Drawing.Size(147, 37);
            this.buttonSinSueToBucket.TabIndex = 3;
            this.buttonSinSueToBucket.Text = "В Корзину";
            this.buttonSinSueToBucket.UseVisualStyleBackColor = false;
            this.buttonSinSueToBucket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSinSueToBucket_MouseClick);
            // 
            // buttonLumineToBucket
            // 
            this.buttonLumineToBucket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLumineToBucket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLumineToBucket.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLumineToBucket.Location = new System.Drawing.Point(224, 302);
            this.buttonLumineToBucket.Name = "buttonLumineToBucket";
            this.buttonLumineToBucket.Size = new System.Drawing.Size(147, 37);
            this.buttonLumineToBucket.TabIndex = 3;
            this.buttonLumineToBucket.Text = "В Корзину";
            this.buttonLumineToBucket.UseVisualStyleBackColor = false;
            this.buttonLumineToBucket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLumineToBucket_MouseClick);
            // 
            // buttonSucroseToBucket
            // 
            this.buttonSucroseToBucket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSucroseToBucket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSucroseToBucket.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSucroseToBucket.Location = new System.Drawing.Point(723, 83);
            this.buttonSucroseToBucket.Name = "buttonSucroseToBucket";
            this.buttonSucroseToBucket.Size = new System.Drawing.Size(147, 37);
            this.buttonSucroseToBucket.TabIndex = 3;
            this.buttonSucroseToBucket.Text = "В Корзину";
            this.buttonSucroseToBucket.UseVisualStyleBackColor = false;
            this.buttonSucroseToBucket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSucroseToBucket_MouseClick);
            // 
            // buttonDilucToBucket
            // 
            this.buttonDilucToBucket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDilucToBucket.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDilucToBucket.Location = new System.Drawing.Point(224, 83);
            this.buttonDilucToBucket.Name = "buttonDilucToBucket";
            this.buttonDilucToBucket.Size = new System.Drawing.Size(147, 37);
            this.buttonDilucToBucket.TabIndex = 3;
            this.buttonDilucToBucket.Text = "В Корзину";
            this.buttonDilucToBucket.UseVisualStyleBackColor = false;
            this.buttonDilucToBucket.Click += new System.EventHandler(this.buttonDilucToBucket_Click);
            // 
            // textBoxSinSue
            // 
            this.textBoxSinSue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSinSue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSinSue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSinSue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSinSue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSinSue.Location = new System.Drawing.Point(723, 261);
            this.textBoxSinSue.Multiline = true;
            this.textBoxSinSue.Name = "textBoxSinSue";
            this.textBoxSinSue.ReadOnly = true;
            this.textBoxSinSue.Size = new System.Drawing.Size(173, 177);
            this.textBoxSinSue.TabIndex = 2;
            this.textBoxSinSue.Text = "Цена, руб.:";
            // 
            // textBoxLumine
            // 
            this.textBoxLumine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLumine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxLumine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLumine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLumine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxLumine.Location = new System.Drawing.Point(224, 261);
            this.textBoxLumine.Multiline = true;
            this.textBoxLumine.Name = "textBoxLumine";
            this.textBoxLumine.ReadOnly = true;
            this.textBoxLumine.Size = new System.Drawing.Size(171, 177);
            this.textBoxLumine.TabIndex = 2;
            this.textBoxLumine.Text = "Цена, руб.: ";
            // 
            // textBoxSucrose
            // 
            this.textBoxSucrose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSucrose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSucrose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSucrose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSucrose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSucrose.Location = new System.Drawing.Point(723, 41);
            this.textBoxSucrose.Multiline = true;
            this.textBoxSucrose.Name = "textBoxSucrose";
            this.textBoxSucrose.ReadOnly = true;
            this.textBoxSucrose.Size = new System.Drawing.Size(173, 177);
            this.textBoxSucrose.TabIndex = 2;
            this.textBoxSucrose.Text = "Цена, руб.:";
            // 
            // textBoxDiluc
            // 
            this.textBoxDiluc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxDiluc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiluc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDiluc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxDiluc.Location = new System.Drawing.Point(224, 41);
            this.textBoxDiluc.Multiline = true;
            this.textBoxDiluc.Name = "textBoxDiluc";
            this.textBoxDiluc.ReadOnly = true;
            this.textBoxDiluc.Size = new System.Drawing.Size(171, 177);
            this.textBoxDiluc.TabIndex = 2;
            this.textBoxDiluc.Text = "Цена, руб.: ";
            // 
            // labelSinSue
            // 
            this.labelSinSue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSinSue.AutoSize = true;
            this.labelSinSue.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinSue.Location = new System.Drawing.Point(717, 226);
            this.labelSinSue.Name = "labelSinSue";
            this.labelSinSue.Size = new System.Drawing.Size(407, 34);
            this.labelSinSue.TabIndex = 1;
            this.labelSinSue.Text = "Фигурка акриловая Син Сю";
            // 
            // labelLumine
            // 
            this.labelLumine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLumine.AutoSize = true;
            this.labelLumine.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLumine.Location = new System.Drawing.Point(218, 224);
            this.labelLumine.Name = "labelLumine";
            this.labelLumine.Size = new System.Drawing.Size(398, 34);
            this.labelLumine.TabIndex = 1;
            this.labelLumine.Text = "Фигурка акриловая Люмин";
            // 
            // labelSucrose
            // 
            this.labelSucrose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSucrose.AutoSize = true;
            this.labelSucrose.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSucrose.Location = new System.Drawing.Point(717, 7);
            this.labelSucrose.Name = "labelSucrose";
            this.labelSucrose.Size = new System.Drawing.Size(438, 34);
            this.labelSucrose.TabIndex = 1;
            this.labelSucrose.Text = "Фигурка акриловая Сахароза";
            // 
            // labelDiluc
            // 
            this.labelDiluc.AutoSize = true;
            this.labelDiluc.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiluc.Location = new System.Drawing.Point(218, 7);
            this.labelDiluc.Name = "labelDiluc";
            this.labelDiluc.Size = new System.Drawing.Size(387, 34);
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
            // buttonMinDiluc
            // 
            this.buttonMinDiluc.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinDiluc.Image")));
            this.buttonMinDiluc.Location = new System.Drawing.Point(384, 83);
            this.buttonMinDiluc.Name = "buttonMinDiluc";
            this.buttonMinDiluc.Size = new System.Drawing.Size(45, 37);
            this.buttonMinDiluc.TabIndex = 8;
            this.buttonMinDiluc.UseVisualStyleBackColor = true;
            this.buttonMinDiluc.Visible = false;
            this.buttonMinDiluc.Click += new System.EventHandler(this.buttonMinDiluc_Click);
            // 
            // buttonMinSucrose
            // 
            this.buttonMinSucrose.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinSucrose.Image")));
            this.buttonMinSucrose.Location = new System.Drawing.Point(885, 83);
            this.buttonMinSucrose.Name = "buttonMinSucrose";
            this.buttonMinSucrose.Size = new System.Drawing.Size(45, 37);
            this.buttonMinSucrose.TabIndex = 8;
            this.buttonMinSucrose.UseVisualStyleBackColor = true;
            this.buttonMinSucrose.Visible = false;
            this.buttonMinSucrose.Click += new System.EventHandler(this.buttonMinSucrose_Click);
            // 
            // buttonMinSinSue
            // 
            this.buttonMinSinSue.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinSinSue.Image")));
            this.buttonMinSinSue.Location = new System.Drawing.Point(885, 346);
            this.buttonMinSinSue.Name = "buttonMinSinSue";
            this.buttonMinSinSue.Size = new System.Drawing.Size(45, 37);
            this.buttonMinSinSue.TabIndex = 8;
            this.buttonMinSinSue.UseVisualStyleBackColor = true;
            this.buttonMinSinSue.Visible = false;
            this.buttonMinSinSue.Click += new System.EventHandler(this.buttonMinSinSue_Click);
            // 
            // buttonMinLumine
            // 
            this.buttonMinLumine.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinLumine.Image")));
            this.buttonMinLumine.Location = new System.Drawing.Point(384, 343);
            this.buttonMinLumine.Name = "buttonMinLumine";
            this.buttonMinLumine.Size = new System.Drawing.Size(45, 37);
            this.buttonMinLumine.TabIndex = 8;
            this.buttonMinLumine.UseVisualStyleBackColor = true;
            this.buttonMinLumine.Visible = false;
            this.buttonMinLumine.Click += new System.EventHandler(this.buttonMinLumine_Click);
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
        private System.Windows.Forms.Button buttonSinSueToBucket;
        private System.Windows.Forms.Button buttonLumineToBucket;
        private System.Windows.Forms.Button buttonSucroseToBucket;
        private System.Windows.Forms.Button buttonDilucToBucket;
        private System.Windows.Forms.TextBox textBoxDilucCost;
        private System.Windows.Forms.TextBox textBoxSinSueCost;
        private System.Windows.Forms.TextBox textBoxLumineCost;
        private System.Windows.Forms.TextBox textBoxSucroseCost;
        private System.Windows.Forms.Button buttonBucket;
        private System.Windows.Forms.Label labelSinSueInBucked;
        private System.Windows.Forms.Label labelLumineInBucked;
        private System.Windows.Forms.Label labelSucroseInBucked;
        private System.Windows.Forms.Label labelDilucInBucked;
        private System.Windows.Forms.TextBox textBoxSinSueKolichestvo;
        private System.Windows.Forms.TextBox textBoxLumineKolichestvo;
        private System.Windows.Forms.TextBox textBoxSucroseKolichestvo;
        private System.Windows.Forms.TextBox textBoxDilucKolichestvo;
        private System.Windows.Forms.Label labelYourBucked;
        private System.Windows.Forms.Button buttonConfirmBuying;
        public System.Windows.Forms.TextBox textBoxBucked;
        private System.Windows.Forms.Button buttonMinLumine;
        private System.Windows.Forms.Button buttonMinSinSue;
        private System.Windows.Forms.Button buttonMinSucrose;
        private System.Windows.Forms.Button buttonMinDiluc;
    }
}