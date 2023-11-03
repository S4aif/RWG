using System;
using Microsoft.AspNetCore.Identity;

namespace RWG.Models
{
	public class User : IdentityUser
	{
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public List<Workout> Workouts { get; set; }
		public List<Progress> Progresses { get; set; }
	}
}

