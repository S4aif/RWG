using System;
namespace RWG.Models
{
	public class Progress
	{
		public int Id { get; set; }
        public int Set { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }

        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public Exercise Exercise { get; set; }
        //DateOnly data type to preview the date and day of workouts performed
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}

