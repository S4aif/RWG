using System;
namespace RWG.Models
{
	public class Workout
	{
        public int Id { get; set; }
        public string Name { get; set; }
        //One to many relationship, Workout to WorkoutExercise
        public List<WorkoutExercise> WorkoutExercises { get; set; }
    }
}

