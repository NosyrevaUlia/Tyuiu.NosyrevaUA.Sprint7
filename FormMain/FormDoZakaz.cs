﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
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
        //-----------------------------------------------------------------------------------------------
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int WMsg, int wParam, int lParam);


        private void panelForButtons_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------

        private void buttonMinimize_Click(object sender, EventArgs e)             
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)             
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Ограничение
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
            this.Hide();
            FormMainMenu Home = new FormMainMenu();
            Home.Show();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void buttonDoZAKAZ_Click(object sender, EventArgs e)              //Кнопка создания заказа 
        {
            int number = 0;
            //Фамилия Имя Отчество Контакты Дата Адрес Номер
            //string[] userData = { textBoxYourNameFirst.Text, textBoxYourNameSecond.Text, textBoxYourNameThird.Text, textBoxYourNumber.Text, textBoxDataDostavki.Text, textBoxAdress.Text};
            if((textBoxYourNameFirst.Text) == "" || (textBoxYourNameSecond.Text=="") || (textBoxYourNameThird.Text=="") || (textBoxYourNumber.Text=="") || (textBoxDataDostavki.Text=="") || (textBoxAdress.Text == "")) { MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                try
                {   
                    StringBuilder scv = new StringBuilder();

                    string pathToSavescv = $@"{Directory.GetCurrentDirectory()}\DataCustomers.csv";
                    number++;
                    scv.AppendLine(textBoxYourNameFirst.Text + ";" + textBoxYourNameSecond.Text + ";" + textBoxYourNameThird.Text + ";" + textBoxYourNumber.Text + ";" + textBoxDataDostavki.Text + ";" + textBoxAdress.Text +";"+number);
                    File.AppendAllText(pathToSavescv, scv.ToString(), Encoding.GetEncoding(1251));

                    DialogResult dialogres = MessageBox.Show("Заказ оформлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Сбой при сохранении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void buttonDobavitTorars_Click(object sender, EventArgs e)             //Попытка корзины
        {
            this.Hide();
            FormTovarLook tovarLook = new FormTovarLook();
            tovarLook.Show();
        }
    }
}
