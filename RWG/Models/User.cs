using System;
using Microsoft.AspNetCore.Identity;

namespace RWG.Models
{
	public class User : IdentityUser
	{
        public string FirstName { get; set; }
        public string Surname { get; set; }
        //One to many relationship, User to Workout
        public List<Workout> Workouts { get; set; }
        //One to many relationship, User to Progress
        public List<Progress> Progresses { get; set; }
	}
}

