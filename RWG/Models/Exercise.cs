using System;
namespace RWG.Models
{
	public class Exercise
	{
		public int Id { get; set; }
		public string video { get; set; }
		public string description { get; set; }
		public List<workoutExercise> workoutExercises { get; set; }
	}
}

