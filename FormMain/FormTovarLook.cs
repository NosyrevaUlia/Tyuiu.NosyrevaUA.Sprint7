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
    public partial class FormTovarLook : Form
    {
        public FormTovarLook()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------------------
        private void buttonClose_Click(object sender, EventArgs e)                //Exit But
        {
            Application.Exit();
        }
        private void buttonMaximize_Click(object sender, EventArgs e)             //Maximized But
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else { this.WindowState = FormWindowState.Normal; }
        }
        private void buttonMinimize_Click(object sender, EventArgs e)              //Minimized But
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //------------------------------------------------------------------------------------------

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu Home = new FormMainMenu();
            Home.Show();
        }
    }
}
