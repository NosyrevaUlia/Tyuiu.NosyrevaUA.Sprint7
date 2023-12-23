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
    public partial class FormTovarLook : Form
    {
        public FormTovarLook()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
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

        private void buttonClose_Click(object sender, EventArgs e)                //Exit But
        {
            Application.Exit();
            this.Text = string.Empty;
            this.ControlBox = false;
        }        

        private void buttonMaximize_Click(object sender, EventArgs e)             //Maximized But
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Ограничение
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
        //------------------------------------------------------------------------------------------
        public int Diluc = 0;
        public int Sucrose = 0;
        public int Lumine = 0;
        public int SinSue = 0;
        public string DilucBucketText;
        public string SucroseBucketText;
        public string LumineBucketText;
        public string SinSueBucketText;

        private void buttonDilucToBucket_Click(object sender, EventArgs e)
        {
            Diluc++;
            int SumDilucCount = Convert.ToInt32(textBoxDilucCost.Text) * Diluc;
            textBoxDilucKolichestvo.Text = Convert.ToString(Diluc);
            if(Diluc!=0)
            {
                DilucBucketText = labelDiluc.Text + ", Количество: " + Convert.ToString(Diluc) + ", Стоимость: " + Convert.ToString(SumDilucCount);
            }
        }
        private void buttonLumineToBucket_MouseClick(object sender, MouseEventArgs e)
        {
            Lumine++;
            int SumLumineCount = Convert.ToInt32(textBoxLumineCost.Text) * Lumine;
            textBoxLumineKolichestvo.Text = Convert.ToString(Lumine);
            if(Lumine!=0)
            {
                LumineBucketText = labelLumine.Text + ", Количество: " + Convert.ToString(Lumine) + ", Стоимость: " + Convert.ToString(SumLumineCount);
            }
        }
        private void buttonSinSueToBucket_MouseClick(object sender, MouseEventArgs e)
        {
            SinSue++;
            int SumSinSue = Convert.ToInt32(textBoxSinSueCost.Text) * SinSue;
            textBoxSinSueKolichestvo.Text = Convert.ToString(SinSue);
            if (SinSue != 0)
            {
                SinSueBucketText = labelSinSue.Text + ", Количество: " + Convert.ToString(SinSue) + ", Стоимость: " + Convert.ToString(SumSinSue);
            }
        }
        private void buttonSucroseToBucket_MouseClick(object sender, MouseEventArgs e)
        {
            Sucrose++;
            int SumSucrose = Convert.ToInt32(textBoxSucroseCost.Text) * Sucrose;
            textBoxSucroseKolichestvo.Text = Convert.ToString(Sucrose);
            if (Sucrose != 0)
            {
                SucroseBucketText = labelSucrose.Text + ", Количество: " + Convert.ToString(Sucrose) + ", Стоимость: " + Convert.ToString(SumSucrose);
            }
        }
        //-----------------------------------------------------------------------------------   корзина        
        private void buttonBucket_Click(object sender, EventArgs e)
        {
            int Summa = Convert.ToInt32(textBoxDilucCost.Text) * Diluc + Convert.ToInt32(textBoxLumineCost.Text) * Lumine + Convert.ToInt32(textBoxSinSueCost.Text) * SinSue + Convert.ToInt32(textBoxSucroseCost.Text) * Sucrose;
            if (Summa != 0)
            { textBoxBucked.Text = DilucBucketText + Environment.NewLine + LumineBucketText + Environment.NewLine + SucroseBucketText + Environment.NewLine + SinSueBucketText + Environment.NewLine + Environment.NewLine + "Итого: " + Summa; }
            
            if(labelYourBucked.Visible == false)
            {
                buttonBucket.Text = "Назад";
                labelAssortiment.Visible = false;
                labelYourBucked.Visible = true;
                textBoxBucked.Visible = true;
            }
            else
            {
                buttonBucket.Text = "Корзина";
                labelAssortiment.Visible = true;
                labelYourBucked.Visible = false;
                textBoxBucked.Visible = false;
            }
            

        }
    }
}
