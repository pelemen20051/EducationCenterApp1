using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationCenterApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            // Проверка логина и пароля (пример с предопределенными данными)
            if (TeacherLogin(login, password))
            {
                MessageBox.Show("Добро пожаловать!");
                MainForm mainForm = new MainForm(); // Открываем основную форму приложения
                mainForm.Show();
                this.Hide(); // Скрываем форму авторизации
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        // Пример проверки логина и пароля
        private bool TeacherLogin(string login, string password)
        {
            // Для тестирования используем фиксированные данные. В будущем заменим на список преподавателей
            return login == "teacher1" && password == "pass123";
        }
    }
}
