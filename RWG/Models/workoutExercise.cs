using System;
namespace RWG.Models
{
	public class WorkoutExercise
	{
		public int Id { get; set; }
        public int Set { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        //many to one
        public Exercise Exercise { get; set; }
        public Workout Workout { get; set; }
    }
}

