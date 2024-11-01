using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenterApp1
{
    internal class Student
    {
        public string Name { get; set; }                // Имя студента
        public string[] Subjects { get; set; }           // Направления, на которые записан студент
        public int[,] Grades { get; set; }               // Оценки: строки - направления, столбцы - занятия

        // Метод для вычисления среднего балла
        public double GetAverageGrade()
        {
            int totalGrades = 0, gradeCount = 0;
            foreach (var grade in Grades)
            {
                totalGrades += grade;
                gradeCount++;
            }
            return gradeCount > 0 ? (double)totalGrades / gradeCount : 0;
        }
    }
}
