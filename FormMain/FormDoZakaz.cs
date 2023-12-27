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
using System.IO;

namespace FormMain
{
    public partial class FormDoZakaz : Form
    {
        public FormDoZakaz()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
        }


        //-----------------------------------------------------------------------------------------------   Двигать окно
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int WMsg, int wParam, int lParam);


        private void panelForButtons_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //----------------------------------------------------------------------------------------------
        private void buttonMinimize_Click(object sender, EventArgs e)             
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)             
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; 
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void buttonClose_Click(object sender, EventArgs e)                
        {
            Application.Exit();
        } 
        
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
        
        private void buttonBucket_Click(object sender, EventArgs e)
        {
            textBoxBucked.Text = ClassDataNeeded.Text;
            if (textBoxBucked.Visible == false)
            {
                buttonBucket.Text = "Назад";
                textBoxBucked.Visible = true;
            }
            else
            {
                buttonBucket.Text = "Корзина";
                textBoxBucked.Visible = false;
            }
        }

        
        private void buttonDoZAKAZ_Click(object sender, EventArgs e)               
        {
            if((textBoxYourNameFirst.Text) == "" || (textBoxYourNameSecond.Text=="") || (textBoxYourNameThird.Text=="") || (textBoxYourNumber.Text=="") || (textBoxDataDostavki.Text=="") || (textBoxAdress.Text == "")) { MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                FirstLibrary ds = new FirstLibrary();
                int numberforscv = ds.Number($@"C:\Users\Юлия\source\repos\Tyuiu.NosyrevaUA.Sprint7\FormMain\bin\Debug\DataCustomers.csv");
                DialogResult diares = MessageBox.Show("Перед отправкой внимательно проверьте правильность введённых данных. Отправить заказ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(diares == DialogResult.Yes)
                {
                    try
                    {
                        
                        StringBuilder scv = new StringBuilder();

                        string pathToSavescv = $@"{Directory.GetCurrentDirectory()}\DataCustomers.csv";
                        
                        scv.AppendLine(textBoxYourNameFirst.Text + ";" + textBoxYourNameSecond.Text + ";" + textBoxYourNameThird.Text + ";" + textBoxYourNumber.Text + ";" + textBoxDataDostavki.Text + ";" + textBoxAdress.Text + ";"+numberforscv);
                        File.AppendAllText(pathToSavescv, scv.ToString(), Encoding.GetEncoding(1251));

                        DialogResult dialogres = MessageBox.Show("Заказ оформлен. При необходимости изменения заказа звоните по номеру, указанному на сайте магазина.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormMainMenu menu = new FormMainMenu();
                        this.Hide();
                        menu.Show();

                    }
                    catch
                    {
                        MessageBox.Show("Сбой при сохранении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            
            
        }
    }
}
