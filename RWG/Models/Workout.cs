using System;
namespace RWG.Models
{
	public class Workout
	{
        public int Id { get; set; }
        public string name { get; set; }
        public List<workoutExercise> workoutExercises { get; set; }
    }
}

