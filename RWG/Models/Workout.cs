using System;
namespace RWG.Models
{
    public class Workout
	{

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Injury> Injuries { get; set; }
        public List<Exercise> Exercises { get; set; }
        public User User { get; set; }
    }
}

