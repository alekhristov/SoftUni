using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Student
{
    public string Name { get; set; }
    public double[] Grades { get; set; }
    public double AverageGrade => this.Grades.Average();
}
namespace _04_AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var studentName = input[0];
                var grades = input
                    .Skip(1)
                    .Select(double.Parse)
                    .ToArray();

                var student = new Student
                {
                    Name = studentName,
                    Grades = grades
                };

                students.Add(student);
            }

            students = students
                .Where(g => g.AverageGrade >= 5)
                .OrderBy(a => a.Name)
                .ThenByDescending(a => a.AverageGrade)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
