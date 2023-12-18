using System;
namespace RWG.Models
{
	public class AddProgressViewModel
	{
		public int ExerciseId { get; set; }
		public int WorkoutId { get; set; }
		public int Set { get; set; }
		public int Reps { get; set; }
		public double Weight { get; set; }

		public ProgressViewModel ProgressViewModel { get; set; }
	}
}

