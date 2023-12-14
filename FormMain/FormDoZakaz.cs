using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormDoZakaz : Form
    {
        public FormDoZakaz()
        {
            InitializeComponent();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)          //Minimize But
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonClose_Click(object sender, EventArgs e)             //Close But
        {
            Application.Exit();
        }
        private void buttonMaximize_Click(object sender, EventArgs e)          //Maximizw But
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else { this.WindowState = FormWindowState.Normal; }
        }
    }
}
