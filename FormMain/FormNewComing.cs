using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormNewComing : Form
    {
        public FormNewComing()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------  Двигать окно
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCpture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int WMsg, int wParam, int lParam);

        private void panelForButtons_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCpture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        private void buttonMinimize_Click(object sender, EventArgs e)         //Min But
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)         //Max But
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Ограничение
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void buttonClose_Click(object sender, EventArgs e)            //Close But
        {
            Application.Exit();
        }
        //--------------------------------------------------------------------------------
        private void buttonHome_Click(object sender, EventArgs e)             //Home 
        {
            this.Hide();
            FormMainMenu Home = new FormMainMenu();
            Home.Show();
        }

    }
}
