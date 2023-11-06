using System;
namespace RWG.Models
{
	public class RegisterViewModel
	{
        //sets the getters and setters for each of these properties to use in other classes
        public string FirstName { get; set; }
        public string Surname { get; set; }
		public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
       
    }
}

