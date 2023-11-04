using System;
namespace RWG.Models
{
	public class Exercise
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Video { get; set; }
		public string Description { get; set; }
		//One to many relationship, Exercise to WorkoutExercise
		public List<WorkoutExercise> WorkoutExercises { get; set; }
	}
}

