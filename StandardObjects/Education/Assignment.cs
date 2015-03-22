using System;

namespace StandardObjects.Education
{
	public class Assignment
	{
		public int AssignmentID { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public double Weight { get; set; }

		public double Score { get; set; }

		public DateTime DateAssigned { get; set; }

		public DateTime DueDate { get; set; }

		public DateTime DateTurnedIn { get; set; }

		public Assignment (int assingmentID, string name, string description, double weight, double score)
		{
			this.AssignmentID = assingmentID;
			this.Name = name;
			this.Description = description;
			this.Weight = weight;
			this.Score = score;
		}
	}
}

