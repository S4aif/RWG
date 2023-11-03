using System;
namespace RWG.Models
{
	public class Exercise
	{
		public int Id { get; set; }
		public string Video { get; set; }
		public string Description { get; set; }
		public List<WorkoutExercise> WorkoutExercises { get; set; }
	}
}

