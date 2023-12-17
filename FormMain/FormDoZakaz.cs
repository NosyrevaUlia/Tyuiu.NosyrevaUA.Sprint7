using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormMain
{
    public partial class FormDoZakaz : Form
    {
        public FormDoZakaz()
        {
            InitializeComponent();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)             //Minimize But
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonMaximize_Click(object sender, EventArgs e)             //Maximize But
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else { this.WindowState = FormWindowState.Normal; }
        }
        private void buttonClose_Click(object sender, EventArgs e)                //Close But
        {
            Application.Exit();
        }        
        private void buttonHome_Click(object sender, EventArgs e)                 //Home But
        {
            this.Hide();
            FormMainMenu Home = new FormMainMenu();
            Home.Show();
        }
        //------------------------------------------------------------------------------------------------------

        private void buttonDoZAKAZ_Click(object sender, EventArgs e)              //Кнопка создания заказа 
        {
            //Фамилия Имя Отчество Контакты Дата Адрес Номер
            //string[] userData = { textBoxYourNameFirst.Text, textBoxYourNameSecond.Text, textBoxYourNameThird.Text, textBoxYourNumber.Text, textBoxDataDostavki.Text, textBoxAdress.Text};
            if((textBoxYourNameFirst.Text) == "" || (textBoxYourNameSecond.Text=="") || (textBoxYourNameThird.Text=="") || (textBoxYourNumber.Text=="") || (textBoxDataDostavki.Text=="") || (textBoxAdress.Text == "")) { MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                try
                {   
                    StringBuilder scv = new StringBuilder();

                    string pathToSavescv = $@"{Directory.GetCurrentDirectory()}\DataCustomers.csv";
                    scv.AppendLine(textBoxYourNameFirst.Text + ";" + textBoxYourNameSecond.Text + ";" + textBoxYourNameThird.Text + ";" + textBoxYourNumber.Text + ";" + textBoxDataDostavki.Text + ";" + textBoxAdress.Text);
                    File.AppendAllText(pathToSavescv, scv.ToString(), Encoding.GetEncoding(1251));

                    DialogResult dialogres = MessageBox.Show("Заказ оформлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Сбой при сохранении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }
    }
}
