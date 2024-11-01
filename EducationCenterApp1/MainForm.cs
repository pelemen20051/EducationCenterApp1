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
    public partial class MainForm : Form
    {

        // Массивы студентов и преподавателей
        Student[] students = {
        new Student { Name = "Иванов Иван", Subjects = new[] {"Математика", "Физика"}, Grades = new int[2, 4] { {5, 4, 5, 4}, {4, 4, 5, 3} }},
        new Student { Name = "Петров Петр", Subjects = new[] {"Информатика"}, Grades = new int[1, 4] { {4, 3, 5, 5} }}
    };

        Teacher[] teachers = {
        new Teacher { Login = "teacher1", Password = "pass123", Name = "Смирнов С.", Subject = "Математика" },
        new Teacher { Login = "teacher2", Password = "pass456", Name = "Иванова А.", Subject = "Физика" }
    };

        int currentMonthIndex = 0; // Переменная для отслеживания текущего занятия в месяце

        public MainForm()
        {
            InitializeComponent();
            // Здесь можно добавить логику инициализации
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            // Пример добавления оценки
            int grade = int.Parse(txtGrade.Text); // Получаем оценку из текстового поля
            int studentIndex = cmbStudent.SelectedIndex; // Получаем индекс выбранного студента
            int subjectIndex = cmbSubject.SelectedIndex; // Получаем индекс выбранного предмета

            if (studentIndex >= 0 && subjectIndex >= 0)
            {
                students[studentIndex].Grades[subjectIndex, currentMonthIndex] = grade;
                MessageBox.Show("Оценка добавлена.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Создаем отчет о студентах с сортировкой по среднему баллу
            var report = students.Select(s => new { s.Name, AverageGrade = s.GetAverageGrade() })
                                 .OrderByDescending(s => s.AverageGrade);

            txtReport.Clear();
            foreach (var student in report)
            {
                txtReport.AppendText($"Студент: {student.Name}, Средний балл: {student.AverageGrade:F2}\n");
            }
        }
    }
}
