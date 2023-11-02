using System;
namespace RWG.Models
{
	public class workoutExercise
	{
		public int Id { get; set; }
        public int set { get; set; }
        public int reps { get; set; }
        public int weight { get; set; }
        public Exercise exercise { get; set; }
        public Workout workout { get; set; }
    }
}

