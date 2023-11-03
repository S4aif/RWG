using System;
namespace RWG.Models
{
	public class WorkoutExercise
	{
		public int Id { get; set; }
        public int Set { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        //many to one relationship from WorkoutExercise to Exercise
        public Exercise Exercise { get; set; }
        //many to one relationship from WorkoutExercise to Workout
        public Workout Workout { get; set; }
    }
}

