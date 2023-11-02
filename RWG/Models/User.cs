using System;
using Microsoft.AspNetCore.Identity;

namespace RWG.Models
{
	public class User : IdentityUser
	{
		public string firstName { get; set; }
		public string surname { get; set; }
		public List<Workout> workouts { get; set; }
		public List<Progress> progresses { get; set; }
	}
}

