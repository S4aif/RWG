using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RWG.Models;

namespace RWG.Context
{
	public class SeedExtension
	{
        private DatabaseContext _context;
		private UserManager<User> _userManager;

        public SeedExtension(DatabaseContext context, UserManager<User> userManager)
		{
			_context = context;
			_userManager = userManager;
		}

		public async Task SeedAsync()
		{
			//make sure database exists
			_context.Database.EnsureCreated();

			//make sure data base is not empty
			var users = _context.Users.Count();
			if (users > 0) return;

			//seed database
			//add user
			var user = new User();
            user.UserName = "Saifshoubaki10@gmail.com";
            user.Email = "Saifshoubaki10@gmail.com";

			var password = "S4aif2447!";
			_ = _userManager.CreateAsync(user, password);

            //seed database with chest exercises
            var chest1 = new Exercise();
			chest1.Name = "Barbell Bench Press";
            chest1.Description = "";
            _context.Exercises.Add(chest1);

            //seed database with chest exercises
            var chest2 = new Exercise();
            chest2.Name = "Dumbbell Bench Press";
            _context.Exercises.Add(chest2);

            //seed database with chest exercises
            var chest3 = new Exercise();
            chest3.Name = "Barbell Incline Bench Press";
            _context.Exercises.Add(chest3);

            //seed database with chest exercises
            var chest4 = new Exercise();
            chest4.Name = "Dymbbell Incline Bench Press";
            _context.Exercises.Add(chest4);

            //seed database with chest exercises
            var chest5 = new Exercise();
            chest5.Name = "Dumbbell Flyes";
            _context.Exercises.Add(chest5);

            //seed database with chest exercises
            var chest6 = new Exercise();
            chest6.Name = "Cable crossover";
            _context.Exercises.Add(chest6);

            //seed database with chest exercises
            var chest7 = new Exercise();
            chest7.Name = "Parallel bar dips";
            _context.Exercises.Add(chest7);

            //seed database with chest exercises
            var chest8 = new Exercise();
            chest8.Name = "Machine Fly";
            _context.Exercises.Add(chest8);

            //seed database with chest exercises
            var chest9 = new Exercise();
            chest9.Name = "Close Grip Bench Press";
            _context.Exercises.Add(chest9);

            //seed database with chest exercises
            var chest10 = new Exercise();
            chest10.Name = "High to low cable flyes";
            _context.Exercises.Add(chest10);

            //seed database with chest exercises
            var chest11 = new Exercise();
            chest11.Name = "Low to High cable Flyes";
            _context.Exercises.Add(chest11);

            //seed database with chest exercises
            var chest12 = new Exercise();
            chest12.Name = "Push ups";
            _context.Exercises.Add(chest12);

            //seed database with chest exercises
            var chest13 = new Exercise();
            chest13.Name = "Incline Push ups";
            _context.Exercises.Add(chest13);

            //seed database with chest exercises
            var chest14 = new Exercise();
            chest14.Name = "Decline Push ups";
            _context.Exercises.Add(chest14);

            //seed database with chest exercises
            var chest15 = new Exercise();
            chest15.Name = "Pullover";
            _context.Exercises.Add(chest15);

            //seed database with chest exercises
            var chest16 = new Exercise();
            chest16.Name = "Explosive push ups";
            _context.Exercises.Add(chest16);


            //seed database with back exercises
            var back1 = new Exercise();
            back1.Name = "Dumbbell Row";
            _context.Exercises.Add(chest16);

            //seed database with back exercises
            var back3 = new Exercise();
            back3.Name = "Lat Pulldown";
            _context.Exercises.Add(back3);

            //seed database with back exercises
            var back4 = new Exercise();
            back4.Name = "bent over row";
            _context.Exercises.Add(back4);

            //seed database with back exercises
            var back5 = new Exercise();
            back5.Name = "pull up";
            _context.Exercises.Add(back5);

            //seed database with back exercises
            var back6 = new Exercise();
            back6.Name = "seated cable row";
            _context.Exercises.Add(back6);

            //seed database with back exercises
            var back7 = new Exercise();
            back7.Name = "Dumbbell pull over";
            _context.Exercises.Add(back7);

            //seed database with back exercises
            var back8 = new Exercise();
            back8.Name = "straight arm pulldown";
            _context.Exercises.Add(back8);

            //seed database with back exercises
            var back9 = new Exercise();
            back9.Name = "Dubbell Shrugs";
            _context.Exercises.Add(back9);

            //seed database with back exercises
            var back10 = new Exercise();
            back10.Name = "Barbell Shrugs";
            _context.Exercises.Add(back10);

            //seed database with back exercises
            var back11 = new Exercise();
            back11.Name = "Wide grip pull up";
            _context.Exercises.Add(back11);

            //seed database with back exercises
            var back12 = new Exercise();
            back12.Name = "supermans";
            _context.Exercises.Add(back12);

            //seed database with back exercises
            var back13 = new Exercise();
            back13.Name = "face pull";
            _context.Exercises.Add(back13);

            //seed database with back exercises
            var back14 = new Exercise();
            back14.Name = "T-bar row";
            _context.Exercises.Add(back14);

            //seed database with back exercises
            var back15 = new Exercise();
            back15.Name = "One arm lat pull down";
            _context.Exercises.Add(back15);


            //seed database with arms exercises
            var arms1 = new Exercise();
            arms1.Name = "Bicep curl";
            _context.Exercises.Add(arms1);

            //seed database with arms exercises
            var arms2 = new Exercise();
            arms2.Name = "Hammer curl";
            _context.Exercises.Add(arms2);

            var arms3 = new Exercise();
            arms3.Name = "Tricep dips";
            _context.Exercises.Add(arms3);

            //seed database with arms exercises
            var arms4 = new Exercise();
            arms4.Name = "Overhead tricep extension";
            _context.Exercises.Add(arms4);

            //seed database with arms exercises
            var arms5 = new Exercise();
            arms5.Name = "Cable tricep kickback";
            _context.Exercises.Add(arms5);

            //seed database with arms exercises
            var arms6 = new Exercise();
            arms6.Name = "Tricep pushdown";
            _context.Exercises.Add(arms6);

            //seed database with arms exercises
            var arms7 = new Exercise();
            arms7.Name = "Diamond pushups";
            _context.Exercises.Add(arms7);

            //seed database with arms exercises
            var arms8 = new Exercise();
            arms8.Name = "Barbell curl";
            _context.Exercises.Add(arms8);

            //seed database with arms exercises
            var arms9 = new Exercise();
            arms9.Name = "ez bar curl";
            _context.Exercises.Add(arms9);

            //seed database with arms exercises
            var arms10 = new Exercise();
            arms10.Name = "Close grip bench press";
            _context.Exercises.Add(arms10);

            //seed database with arms exercises
            var arms11 = new Exercise();
            arms11.Name = "Dumbbell preacher curls";
            _context.Exercises.Add(arms11);

            //seed database with arms exercises
            var arms12 = new Exercise();
            arms12.Name = "Skull crusher";
            _context.Exercises.Add(arms12);


            //seed database with shoulders exercises
            var shoulders1 = new Exercise();
            shoulders1.Name = "Overhead shoulder press";

            //seed database with shoulders exercises
            var shoulders2 = new Exercise();
            shoulders2.Name = "Rear delt raises";
            _context.Exercises.Add(shoulders2);

            //seed database with shoulders exercises
            var shoulders3 = new Exercise();
            shoulders3.Name = "Dumbbell Lateral Raises";
            _context.Exercises.Add(shoulders3);

            //seed database with shoulders exercises
            var shoulders4 = new Exercise();
            shoulders4.Name = "Single arm cable lateral raise";
            _context.Exercises.Add(shoulders4);

            //seed database with shoulders exercises
            var shoulders5 = new Exercise();
            shoulders5.Name = "Dumbbell front Raise";
            _context.Exercises.Add(shoulders5);

            //seed database with shoulders exercises
            var shoulders6 = new Exercise();
            shoulders6.Name = "Barbell front raise";
            _context.Exercises.Add(shoulders6);

            //seed database with shoulders exercises
            var shoulders7 = new Exercise();
            shoulders7.Name = "Upright row";
            _context.Exercises.Add(shoulders7);

            //seed database with shoulders exercises
            var shoulders8 = new Exercise();
            shoulders8.Name = "Face pull";
            _context.Exercises.Add(shoulders8);

            //seed database with shoulders exercises
            var shoulders9 = new Exercise();
            shoulders9.Name = "Arnold press";
            _context.Exercises.Add(shoulders9);

            //seed database with shoulders exercises
            var shoulders10 = new Exercise();
            shoulders10.Name = "Reverse Machine flyes";
            _context.Exercises.Add(shoulders10);

            //seed database with shoulders exercises
            var shoulders11 = new Exercise();
            shoulders11.Name = "Pike push ups";
            _context.Exercises.Add(shoulders11);

            //seed database with shoulders exercises
            var shoulders12 = new Exercise();
            shoulders12.Name = "wall assisted handstand push ups";
            _context.Exercises.Add(shoulders12);

            //seed database with shoulders exercises
            var shoulders13 = new Exercise();
            shoulders13.Name = "Handstand push ups";
            _context.Exercises.Add(shoulders13);


            //seed database with legs exercises
            var legs1 = new Exercise();
            legs1.Name = "bodyweight Squats";
            _context.Exercises.Add(legs1);

            //seed database with legs exercises
            var legs2 = new Exercise();
            legs2.Name = "Barbell back squat";
            _context.Exercises.Add(legs2);

            //seed database with legs exercises
            var legs3 = new Exercise();
            legs3.Name = "Barbell front squat";
            _context.Exercises.Add(legs3);

            //seed database with legs exercises
            var legs4 = new Exercise();
            legs4.Name = "leg press";
            _context.Exercises.Add(legs4);

            //seed database with legs exercises
            var legs5 = new Exercise();
            legs5.Name = "leg extention";
            _context.Exercises.Add(legs5);

            //seed database with legs exercises
            var legs = new Exercise();
            legs.Name = "hamstring curl";
            _context.Exercises.Add(legs);

            //seed database with legs exercises
            var legs6 = new Exercise();
            legs6.Name = "split squat";
            _context.Exercises.Add(legs6);

            //seed database with legs exercises
            var legs7 = new Exercise();
            legs7.Name = "Dumbbell romanian deadlift";
            _context.Exercises.Add(legs7);

            //seed database with legs exercises
            var legs8 = new Exercise();
            legs8.Name = "calf raises";
            _context.Exercises.Add(legs8);

            //seed database with legs exercises
            var legs9 = new Exercise();
            legs9.Name = "Bulgarian squat";
            _context.Exercises.Add(legs9);

            _context.SaveChanges();
            
        }
    }
}

