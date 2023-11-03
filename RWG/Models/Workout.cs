using System;
namespace RWG.Models
{
	public class Workout
	{
        public int Id { get; set; }
        public string Name { get; set; }
        //one to many
        public List<WorkoutExercise> WorkoutExercises { get; set; }
    }
}

