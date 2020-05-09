using System;
using System.Windows.Forms;

namespace SystemTray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            //Включаем отображения приложения на панели задач при запуске
            this.ShowInTaskbar = true;
            //Показываем форму
            this.Show();
            //Отключаем доступность пункта меню mnuShow
            mnuShow.Enabled = false;
            //Включаем доступность пункта меню mnuHide
            mnuHide.Enabled = true;
            //Переменной Hidden устанавливаем значение false
        }

        private void mnuHide_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
            mnuShow.Enabled = true;
            mnuHide.Enabled = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            mnuShow_Click(this, new EventArgs());
        }
    }
}
