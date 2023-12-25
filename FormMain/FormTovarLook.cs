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
            DialogResult diares = MessageBox.Show("При переходе на главное меню все введённые данные не сохранятся. Вернуться в главное меню?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (diares == DialogResult.Yes)
            {
                this.Hide();
                FormMainMenu Home = new FormMainMenu();
                Home.Show();
            }
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
            buttonMinDiluc.Visible = true;

            Diluc++;
            int SumDilucCount = Convert.ToInt32(textBoxDilucCost.Text) * Diluc;
            textBoxDilucKolichestvo.Text = Convert.ToString(Diluc);
            if(Diluc!=0)
            {
                DilucBucketText = labelDiluc.Text + ", Количество: " + Convert.ToString(Diluc) + ", Стоимость: " + Convert.ToString(SumDilucCount) +" руб.";
            }
            buttonConfirmBuying.Enabled = true;
        }
        private void buttonLumineToBucket_MouseClick(object sender, MouseEventArgs e)
        {
            buttonMinLumine.Visible = true;

            Lumine++;
            int SumLumineCount = Convert.ToInt32(textBoxLumineCost.Text) * Lumine;
            textBoxLumineKolichestvo.Text = Convert.ToString(Lumine);
            if(Lumine!=0)
            {
                LumineBucketText = labelLumine.Text + ", Количество: " + Convert.ToString(Lumine) + ", Стоимость: " + Convert.ToString(SumLumineCount) + " руб.";
            }
            buttonConfirmBuying.Enabled = true;
        }
        private void buttonSinSueToBucket_MouseClick(object sender, MouseEventArgs e)
        {
            buttonMinSinSue.Visible = true;

            SinSue++;
            int SumSinSue = Convert.ToInt32(textBoxSinSueCost.Text) * SinSue;
            textBoxSinSueKolichestvo.Text = Convert.ToString(SinSue);
            if (SinSue != 0)
            {
                SinSueBucketText = labelSinSue.Text + ", Количество: " + Convert.ToString(SinSue) + ", Стоимость: " + Convert.ToString(SumSinSue) + " руб.";
            }
            buttonConfirmBuying.Enabled = true;
        }
        private void buttonSucroseToBucket_MouseClick(object sender, MouseEventArgs e)
        {
            buttonMinSucrose.Visible = true;

            Sucrose++;
            int SumSucrose = Convert.ToInt32(textBoxSucroseCost.Text) * Sucrose;
            textBoxSucroseKolichestvo.Text = Convert.ToString(Sucrose);
            if (Sucrose != 0)
            {
                SucroseBucketText = labelSucrose.Text + ", Количество: " + Convert.ToString(Sucrose) + ", Стоимость: " + Convert.ToString(SumSucrose) + " руб.";
            }
            buttonConfirmBuying.Enabled = true;
        }

        private void buttonMinDiluc_Click(object sender, EventArgs e)
        {
            if (Diluc == 1)
            {
                DilucBucketText = "";
                Diluc--;
                textBoxDilucKolichestvo.Text = Convert.ToString(Diluc);
                buttonMinDiluc.Visible = false;
            }
            else
            {
                Diluc--;
                textBoxDilucKolichestvo.Text = Convert.ToString(Diluc);
                int SumDilucCount = Convert.ToInt32(textBoxDilucCost.Text) * Diluc;

                DilucBucketText = labelDiluc.Text + ", Количество: " + Convert.ToString(Diluc) + ", Стоимость: " + Convert.ToString(SumDilucCount) + " руб.";
            }
            if ((Diluc == 0) && (Sucrose == 0) && (Lumine == 0) && (SinSue == 0)) { buttonConfirmBuying.Enabled = false; }
        }

        private void buttonMinSucrose_Click(object sender, EventArgs e)
        {
            if (Sucrose == 1)
            {
                Sucrose--;
                textBoxSucroseKolichestvo.Text = Convert.ToString(Sucrose);                
                SucroseBucketText = ""; 
                buttonMinSucrose.Visible = false;                
            }
            else
            {
                Sucrose--;
                textBoxSucroseKolichestvo.Text = Convert.ToString(Sucrose);
                int SumSucroseCount = Convert.ToInt32(textBoxSucroseCost.Text) * Sucrose;
                
                SucroseBucketText = labelSucrose.Text + ", Количество: " + Convert.ToString(Sucrose) + ", Стоимость: " + Convert.ToString(SumSucroseCount) + " руб.";                
            }
            if ((Diluc == 0) && (Sucrose == 0) && (Lumine == 0) && (SinSue == 0)) { buttonConfirmBuying.Enabled = false; }
        }

        private void buttonMinLumine_Click(object sender, EventArgs e)
        {
            if (Lumine == 1)
            {
                Lumine--;
                textBoxLumineKolichestvo.Text = Convert.ToString(Lumine);
                LumineBucketText = ""; 
                buttonMinLumine.Visible = false;
            }
            else
            {
                Lumine--;
                textBoxLumineKolichestvo.Text = Convert.ToString(Lumine);
                int luminecount = Convert.ToInt32(textBoxLumineCost.Text) * Lumine;

                LumineBucketText = labelLumine.Text + ", Количество: " + Convert.ToString(Lumine) + ", Стоимость: " + Convert.ToString(luminecount) + " руб.";
            }
            if ((Diluc == 0) && (Sucrose == 0) && (Lumine == 0) && (SinSue == 0)) { buttonConfirmBuying.Enabled = false; }
        }

        private void buttonMinSinSue_Click(object sender, EventArgs e)
        {
            if (SinSue == 1)
            {
                SinSue--;
                textBoxSinSueKolichestvo.Text = Convert.ToString(SinSue);
                SinSueBucketText = ""; 
                buttonMinSinSue.Visible = false;
            }
            else
            {
                SinSue--;
                int SumSinSue = Convert.ToInt32(textBoxSinSueCost.Text) * SinSue;
                textBoxSinSueKolichestvo.Text = Convert.ToString(SinSue);

                SinSueBucketText = labelSinSue.Text + ", Количество: " + Convert.ToString(SinSue) + ", Стоимость: " + Convert.ToString(SumSinSue) + " руб.";
            }
            if ((Diluc == 0) && (Sucrose == 0) && (Lumine == 0) && (SinSue == 0)) { buttonConfirmBuying.Enabled = false; }
        }


        //-----------------------------------------------------------------------------------   корзина        
        private void buttonBucket_Click(object sender, EventArgs e)
        {
            if ((Diluc == 0) && (Sucrose == 0) && (Lumine == 0) && (SinSue == 0))
            {
                textBoxBucked.Text = ""; 
            }
            int Summa = Convert.ToInt32(textBoxDilucCost.Text) * Diluc + Convert.ToInt32(textBoxLumineCost.Text) * Lumine + Convert.ToInt32(textBoxSinSueCost.Text) * SinSue + Convert.ToInt32(textBoxSucroseCost.Text) * Sucrose;
            if (Summa != 0)
            { textBoxBucked.Text = DilucBucketText + Environment.NewLine + LumineBucketText + Environment.NewLine + SucroseBucketText + Environment.NewLine + SinSueBucketText + Environment.NewLine + Environment.NewLine + "Итого: " + Summa + " руб."; }
            
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

        private void buttonConfirmBuying_Click(object sender, EventArgs e)
        {
            int Summa = Convert.ToInt32(textBoxDilucCost.Text) * Diluc + Convert.ToInt32(textBoxLumineCost.Text) * Lumine + Convert.ToInt32(textBoxSinSueCost.Text) * SinSue + Convert.ToInt32(textBoxSucroseCost.Text) * Sucrose;
            if (Summa != 0)
            { textBoxBucked.Text = DilucBucketText + Environment.NewLine + LumineBucketText + Environment.NewLine + SucroseBucketText + Environment.NewLine + SinSueBucketText + Environment.NewLine + Environment.NewLine + "Итого: " + Summa + " руб."; }
            try
            {
                DialogResult dialogResult = MessageBox.Show("Обратите внимание! После перехода на следущую вкладку изменить список товаров будет нельзя. ", "Подтвердите выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {                    
                    this.Hide();
                    FormDoZakaz doZakaz = new FormDoZakaz();
                    ClassDataNeeded.Text = textBoxBucked.Text;
                    doZakaz.Show();                    
                }
            }
            catch { MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
