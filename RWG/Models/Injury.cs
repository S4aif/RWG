using System;
namespace RWG.Models
{
	public class Injury
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Exercise> Exercises { get; set; }


        public List<Workout> Workouts { get; set; }
    }
}