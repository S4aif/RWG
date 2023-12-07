using System;
namespace RWG.Models
{
	public class Exercise
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Video { get; set; }
		public string Description { get; set; }
        public List<Injury> Injuries { get; set; } = new List<Injury>();
        //One to many relationship, Exercise to WorkoutExercise
        //public List<WorkoutExercise> WorkoutExercises { get; set; }


        public List<Workout> Workouts { get; set; }


    }

    }





