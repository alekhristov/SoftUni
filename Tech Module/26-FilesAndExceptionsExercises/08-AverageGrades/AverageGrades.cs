﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AverageGrades
{
	class AverageGrades
	{
		static void Main(string[] args)
		{
			static void Main(string[] args)
		{
			int studentsCount = int.Parse(Console.ReadLine());
			Student[] students = new Student[studentsCount];

			for (int i = 0; i < studentsCount; i++)
			{
				students[i] = ReadStudent(Console.ReadLine());
			}

			foreach (Student student in students.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
			{
				Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageGrade);
			}
		}

		static Student ReadStudent(string input)
		{
			string[] tokens = input.Split(' ');
			List<double> grades = new List<double>();
			foreach (string token in tokens.Skip(1))
			{
				grades.Add(double.Parse(token));
			}

			return new Student { Name = tokens[0], Grades = grades };
		}
		}
	}
}