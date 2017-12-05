using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AverageGrades
{
	class Student
	{
		public string Name { get; set; }

		public List<double> Grades { get; set; }

		public double AverageGrade { get { return Grades.Sum() / Grades.Count; } }
	}
}
