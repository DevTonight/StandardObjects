using System;
using System.Collections.Generic;

namespace StandardObjects.Education
{
	public class Student
	{
		public int StudentID { get; set; }

		public string FirstName { get; set; }

		public char MiddleInitial { get; set; }

		public string LastName { get; set; }

		public char Gender { get; set; }

		public HashSet<Assignment> Assignments{ get; set; }

		public Student (int studentID, string firstName, char middleInitial, string lastName, char gender)
		{
			this.StudentID = studentID;
			this.FirstName = firstName;
			this.MiddleInitial = middleInitial;
			this.LastName = lastName;
			this.Gender = gender;
			this.Assignments = new HashSet<Assignment> ();

		}
	}
}

