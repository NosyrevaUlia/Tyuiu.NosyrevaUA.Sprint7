using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FirstLib;

namespace FormMain
{
    public partial class FormMainMenu : Form
    {
        //private Form active;

        public FormMainMenu()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------    Двигать окно
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int WMsg, int wParam, int lParam);

        private void panelForButtons_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------

        private void buttonDoDelivery_Click(object sender, EventArgs e)           //Кнопка заказа
        {
            this.Hide();
            FormDoZakaz doZakaz = new FormDoZakaz();
            doZakaz.Show();

        }

        private void buttonAboutUs_Click(object sender, EventArgs e)              //О нас
        {

        }
        //--------------------------------------------------------------------------------------------------
        private void buttonClose_Click(object sender, EventArgs e)                //Кнопка выхода
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)             //Кнопка во весь экран
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Ограничение
            if (WindowState== FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)             //Кнопка сжатия
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //---------------------------------------------------------------------------------------------------
        
        private void buttonTovarLook_Click(object sender, EventArgs e)            //Посмотреть Ассортимент
        {
            this.Hide();
            FormTovarLook  formTovarLook = new FormTovarLook(); 
            formTovarLook.Show();
        }

        private void buttonNewComing_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewComing formNewComing = new FormNewComing();
            formNewComing.Show();

        }

       
    }
}
