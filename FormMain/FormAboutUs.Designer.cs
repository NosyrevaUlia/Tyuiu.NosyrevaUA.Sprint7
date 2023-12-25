namespace FormMain
{
    partial class FormAboutUs
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
            this.textBoxUp = new System.Windows.Forms.TextBox();
            this.textBoDown = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUp
            // 
            this.textBoxUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxUp.Location = new System.Drawing.Point(0, 0);
            this.textBoxUp.Multiline = true;
            this.textBoxUp.Name = "textBoxUp";
            this.textBoxUp.Size = new System.Drawing.Size(918, 275);
            this.textBoxUp.TabIndex = 0;
            // 
            // textBoDown
            // 
            this.textBoDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoDown.Location = new System.Drawing.Point(0, 275);
            this.textBoDown.Multiline = true;
            this.textBoDown.Name = "textBoDown";
            this.textBoDown.Size = new System.Drawing.Size(918, 248);
            this.textBoDown.TabIndex = 1;
            // 
            // FormAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(918, 523);
            this.Controls.Add(this.textBoDown);
            this.Controls.Add(this.textBoxUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAboutUs";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUp;
        private System.Windows.Forms.TextBox textBoDown;
    }
}