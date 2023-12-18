using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            user.FirstName = "Saif";
            user.Surname = "TheLegend";

			var password = " ";
			_ = _userManager.CreateAsync(user, password);


/*----------------------------------------------------------------------------*/
            // Injury groups

            var legInjury = new Injury();
            legInjury.Name = "Leg injury";
            _context.Injuries.Add(legInjury);
    
            var shoulderInjury = new Injury();
            shoulderInjury.Name = "Shoulder injury";
            _context.Injuries.Add(shoulderInjury);

            var bicepInjury = new Injury();
            bicepInjury.Name = "Bicep Injury";
            _context.Injuries.Add(bicepInjury);

            var tricepInjury = new Injury();
            tricepInjury.Name = "Tricep injury";
            _context.Injuries.Add(tricepInjury);

            var chestInjury = new Injury();
            chestInjury.Name = "Chest injury";
            _context.Injuries.Add(chestInjury);

            var backInjury = new Injury();
            backInjury.Name = "Back injury";
            _context.Injuries.Add(backInjury);
/*----------------------------------------------------------------------------*/

            //Chest Exercises


            //seed database with chest exercises
            var chest1 = new Exercise();
			chest1.Name = "Barbell Bench Press";
            //to filter Home workout or Gym workout or both home and gym workout
            chest1.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest1.Video = @"https://www.youtube.com/embed/VXjPjzEjRSU";
            //Adds exercise to Injury group
            chest1.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest1);

            //seed database with chest exercises
            var chest2 = new Exercise();
            chest2.Name = "Dumbbell Bench Press";
            //to filter Home workout or Gym workout or both home and gym workout
            chest2.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest2.Video = @"https://www.youtube.com/embed/1V3vpcaxRYQ";
            //Adds exercise to Injury group
            chest2.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest2);

            //seed database with chest exercises
            var chest3 = new Exercise();
            chest3.Name = "Barbell Incline Bench Press";
            //to filter Home workout or Gym workout or both home and gym workout
            chest3.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest3.Video = @"https://www.youtube.com/embed/cq-4gME3IFY";
            //Adds exercise to Injury group
            chest3.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest3);

            //seed database with chest exercises
            var chest4 = new Exercise();
            chest4.Name = "Dumbbell Incline Bench Press";
            //to filter Home workout or Gym workout or both home and gym workout
            chest4.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest4.Video = @"https://www.youtube.com/embed/Gruq177Psnk";
            //Adds exercise to Injury group
            chest4.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest4);

            //seed database with chest exercises
            var chest5 = new Exercise();
            chest5.Name = "Dumbbell Flyes";
            //to filter Home workout or Gym workout or both home and gym workout
            chest5.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest5.Video = @"https://www.youtube.com/embed/J49byaRpuMw";
            //Adds exercise to Injury group
            chest5.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest5);

            //seed database with chest exercises
            var chest6 = new Exercise();
            chest6.Name = "Cable crossover";
            //to filter Home workout or Gym workout or both home and gym workout
            chest6.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest6.Video = @"https://www.youtube.com/embed/6NM7oplcqtU";
            //Adds exercise to Injury group
            chest6.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest6);

            //seed database with chest exercises
            var chest7 = new Exercise();
            chest7.Name = "Parallel bar dips";
            //to filter Home workout or Gym workout or both home and gym workout
            chest7.Description = "both home and gym workout";
            //The video link to guide the user how to perform the exercise
            chest7.Video = @"https://www.youtube.com/embed/1_4OICx2WrY";
            //Adds exercise to Injury group
            chest7.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest7);

            //seed database with chest exercises
            var chest8 = new Exercise();
            chest8.Name = "Machine Fly";
            //to filter Home workout or Gym workout or both home and gym workout
            chest8.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest8.Video = @"https://www.youtube.com/embed/NEXwXAJ3D2A";
            //Adds exercise to Injury group
            chest8.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest8);

            //seed database with chest exercises
            var chest9 = new Exercise();
            chest9.Name = "Close Grip Bench Press";
            //to filter Home workout or Gym workout or both home and gym workout
            chest9.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest9.Video = @"https://www.youtube.com/embed/VYC2QZEOIUI";
            //Adds exercise to Injury group
            chest9.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest9);

            //seed database with chest exercises
            var chest10 = new Exercise();
            chest10.Name = "High to low cable flyes";
            //to filter Home workout or Gym workout or both home and gym workout
            chest10.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest10.Video = @"https://www.youtube.com/embed/kHs4cHcu5b0";
            //Adds exercise to Injury group
            chest10.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest10);

            //seed database with chest exercises
            var chest11 = new Exercise();
            chest11.Name = "Low to High cable Flyes";
            //to filter Home workout or Gym workout or both home and gym workout
            chest11.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest11.Video = @"https://www.youtube.com/embed/ZWa8v57fCZ8";
            //Adds exercise to Injury group
            chest11.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest11);

            //seed database with chest exercises
            var chest12 = new Exercise();
            chest12.Name = "Push ups";
            //to filter Home workout or Gym workout or both home and gym workout
            chest12.Description = "Home";
            //The video link to guide the user how to perform the exercise
            chest12.Video = @"https://www.youtube.com/embed/yQEx9OC2C3E";
            //Adds exercise to Injury group
            chest12.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest12);

            //seed database with chest exercises
            var chest13 = new Exercise();
            chest13.Name = "Incline Push ups";
            //to filter Home workout or Gym workout or both home and gym workout
            chest13.Description = "Home";
            //The video link to guide the user how to perform the exercise
            chest13.Video = @"https://www.youtube.com/embed/Mc-Kdwnx_M8";
            //Adds exercise to Injury group
            chest13.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest13);

            //seed database with chest exercises
            var chest14 = new Exercise();
            chest14.Name = "Decline Push ups";
            //to filter Home workout or Gym workout or both home and gym workout
            chest14.Description = "Home";
            //The video link to guide the user how to perform the exercise
            chest14.Video = @"https://www.youtube.com/embed/dcV-ATSeryA";
            //Adds exercise to Injury group
            chest14.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest14);

            //seed database with chest exercises
            var chest15 = new Exercise();
            chest15.Name = "Dumbbell Pullover";
            //to filter Home workout or Gym workout or both home and gym workout
            chest15.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            chest15.Video = @"https://www.youtube.com/embed/raU5C9bWo9U";
            //Adds exercise to Injury group
            chest15.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest15);

            //seed database with chest exercises
            var chest16 = new Exercise();
            chest16.Name = "Explosive push ups";
            //to filter Home workout or Gym workout or both home and gym workout
            chest16.Description = "Home";
            //The video link to guide the user how to perform the exercise
            chest16.Video = @"https://www.youtube.com/embed/jXNILmxCVxU";
            //Adds exercise to Injury group
            chest16.Injuries.Add(chestInjury);
            _context.Exercises.Add(chest16);

/*----------------------------------------------------------------------------*/

            
            //Back Exercises


            //seed database with back exercises
            var back1 = new Exercise();
            back1.Name = "Dumbbell Row";
            //to filter Home workout or Gym workout or both home and gym workout
            back1.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back1.Video = @"https://www.youtube.com/embed/GDrJlDB0isk";
            //Adds exercise to Injury group
            back1.Injuries.Add(backInjury);
            _context.Exercises.Add(back1);

            //seed database with back exercises
            var back2 = new Exercise();
            back2.Name = "Lat Pulldown";
            //to filter Home workout or Gym workout or both home and gym workout
            back2.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back2.Video = @"https://www.youtube.com/embed/77bPLrsMwiQ";
            //Adds exercise to Injury group
            back2.Injuries.Add(backInjury);
            _context.Exercises.Add(back2);

            //seed database with back exercises
            var back3 = new Exercise();
            back3.Name = "bent over row";
            //to filter Home workout or Gym workout or both home and gym workout
            back3.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back3.Video = @"https://www.youtube.com/embed/DgyslsszCQ0";
            //Adds exercise to Injury group
            back3.Injuries.Add(backInjury);
            _context.Exercises.Add(back3);

            //seed database with back exercises
            var back4 = new Exercise();
            back4.Name = "pull up";
            //to filter Home workout or Gym workout or both home and gym workout
            back4.Description = "both home and gym workout";
            //The video link to guide the user how to perform the exercise
            back4.Video = @"https://www.youtube.com/embed/dvG8B2OjfWk";
            //Adds exercise to Injury group
            back4.Injuries.Add(backInjury);
            _context.Exercises.Add(back4);

            //seed database with back exercises
            var back5 = new Exercise();
            back5.Name = "seated cable row";
            //to filter Home workout or Gym workout or both home and gym workout
            back5.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back5.Video = @"https://www.youtube.com/embed/z7C7PxVDAD0";
            //Adds exercise to Injury group
            back5.Injuries.Add(backInjury);
            _context.Exercises.Add(back5);

            //seed database with back exercises
            var back6 = new Exercise();
            back6.Name = "Dumbbell pullover";
            //to filter Home workout or Gym workout or both home and gym workout
            back6.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back6.Video = @"https://www.youtube.com/embed/raU5C9bWo9U";
            //Adds exercise to Injury group
            back6.Injuries.Add(backInjury);
            _context.Exercises.Add(back6);

            //seed database with back exercises
            var back7 = new Exercise();
            back7.Name = "straight arm pulldown";
            //to filter Home workout or Gym workout or both home and gym workout
            back7.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back7.Video = @"https://www.youtube.com/embed/1_E77qhMpkE";
            //Adds exercise to Injury group
            back7.Injuries.Add(backInjury);
            _context.Exercises.Add(back7);

            //seed database with back exercises
            var back8 = new Exercise();
            back8.Name = "Dumbbell Shrugs";
            //to filter Home workout or Gym workout or both home and gym workout
            back8.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back8.Video = @"https://www.youtube.com/embed/R3FLhX81MYg";
            //Adds exercise to Injury group
            back8.Injuries.Add(backInjury);
            _context.Exercises.Add(back8);

            //seed database with back exercises
            var back9 = new Exercise();
            back9.Name = "Barbell Shrugs";
            //to filter Home workout or Gym workout or both home and gym workout
            back9.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back9.Video = @"https://www.youtube.com/embed/MlqHEfydPpE";
            //Adds exercise to Injury group
            back9.Injuries.Add(backInjury);
            _context.Exercises.Add(back9);

            //seed database with back exercises
            var back10 = new Exercise();
            back10.Name = "Wide grip pull up";
            //to filter Home workout or Gym workout or both home and gym workout
            back10.Description = "both home and gym workout";
            //The video link to guide the user how to perform the exercise
            back10.Video = @"https://www.youtube.com/embed/NwrJk3AWX50";
            //Adds exercise to Injury group
            back10.Injuries.Add(backInjury);
            _context.Exercises.Add(back10);

            //seed database with back exercises
            var back11 = new Exercise();
            back11.Name = "supermans";
            //to filter Home workout or Gym workout or both home and gym workout
            back11.Description = "Home";
            //The video link to guide the user how to perform the exercise
            back11.Video = @"https://www.youtube.com/embed/KTWWh3GsyYw";
            //Adds exercise to Injury group
            back11.Injuries.Add(backInjury);
            _context.Exercises.Add(back11);

            //seed database with back exercises
            var back12 = new Exercise();
            back12.Name = "face pull";
            //to filter Home workout or Gym workout or both home and gym workout
            back12.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back12.Video = @"https://www.youtube.com/embed/LJN-sT_6OYY";
            //Adds exercise to Injury group
            back12.Injuries.Add(backInjury);
            _context.Exercises.Add(back12);

            //seed database with back exercises
            var back13 = new Exercise();
            back13.Name = "T-bar row";
            //to filter Home workout or Gym workout or both home and gym workout
            back13.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back13.Video = @"https://www.youtube.com/embed/8c23NBbwLBc";
            //Adds exercise to Injury group
            back13.Injuries.Add(backInjury);
            _context.Exercises.Add(back13);

            //seed database with back exercises
            var back14 = new Exercise();
            back14.Name = "One arm lat pull down";
            //to filter Home workout or Gym workout or both home and gym workout
            back14.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            back14.Video = @"https://www.youtube.com/embed/wYy32uk4Bu8";
            //Adds exercise to Injury group
            back14.Injuries.Add(backInjury);
            _context.Exercises.Add(back14);

/*----------------------------------------------------------------------------*/

            
            //Arms Exercises


            //seed database with arms exercises
            var arms1 = new Exercise();
            arms1.Name = "Bicep curl";
            //to filter Home workout or Gym workout or both home and gym workout
            arms1.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms1.Video = @"https://www.youtube.com/embed/2jpteC44QKg";
            //Adds exercise to Injury group
            arms1.Injuries.Add(bicepInjury);
            _context.Exercises.Add(arms1);

            //seed database with arms exercises
            var arms2 = new Exercise();
            arms2.Name = "Hammer curl";
            //to filter Home workout or Gym workout or both home and gym workout
            arms2.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms2.Video = @"https://www.youtube.com/embed/6fcemy1cjkI";
            //Adds exercise to Injury group
            arms2.Injuries.Add(bicepInjury);
            _context.Exercises.Add(arms2);

            var arms3 = new Exercise();
            arms3.Name = "Tricep dips";
            //to filter Home workout or Gym workout or both home and gym workout
            arms3.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms3.Video = @"https://www.youtube.com/embed/36krJZYK_dU";
            //Adds exercise to Injury group
            arms3.Injuries.Add(tricepInjury);
            _context.Exercises.Add(arms3);

            //seed database with arms exercises
            var arms4 = new Exercise();
            arms4.Name = "Overhead tricep extension";
            //to filter Home workout or Gym workout or both home and gym workout
            arms4.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms4.Video = @"https://www.youtube.com/embed/Q3bO1Fh4734";
            //Adds exercise to Injury group
            arms4.Injuries.Add(tricepInjury);
            _context.Exercises.Add(arms4);

            //seed database with arms exercises
            var arms5 = new Exercise();
            arms5.Name = "Cable tricep kickback";
            //to filter Home workout or Gym workout or both home and gym workout
            arms5.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms5.Video = @"https://www.youtube.com/embed/NIp8MdPKTaI";
            //Adds exercise to Injury group
            arms5.Injuries.Add(tricepInjury);
            _context.Exercises.Add(arms5);

            //seed database with arms exercises
            var arms6 = new Exercise();
            arms6.Name = "Tricep pushdown";
            //to filter Home workout or Gym workout or both home and gym workout
            arms6.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms6.Video = @"https://www.youtube.com/embed/NvZKjiZ8NYc";
            //Adds exercise to Injury group
            arms6.Injuries.Add(tricepInjury);
            _context.Exercises.Add(arms6);

            //seed database with arms exercises
            var arms7 = new Exercise();
            arms7.Name = "Diamond pushups";
            //to filter Home workout or Gym workout or both home and gym workout
            arms7.Description = "Home";
            //The video link to guide the user how to perform the exercise
            arms7.Video = @"https://www.youtube.com/embed/PPTj-MW2tcs";
            //Adds exercise to Injury group
            arms7.Injuries.Add(tricepInjury);
            _context.Exercises.Add(arms7);

            //seed database with arms exercises
            var arms8 = new Exercise();
            arms8.Name = "Barbell curl";
            //to filter Home workout or Gym workout or both home and gym workout
            arms8.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms8.Video = @"https://www.youtube.com/embed/N6paU6TGFWU";
            //Adds exercise to Injury group
            arms8.Injuries.Add(bicepInjury);
            _context.Exercises.Add(arms8);

            //seed database with arms exercises
            var arms9 = new Exercise();
            arms9.Name = "ez bar curl";
            //to filter Home workout or Gym workout or both home and gym workout
            arms9.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms9.Video = @"https://www.youtube.com/embed/Aundcd6gv1w";
            //Adds exercise to Injury group
            arms9.Injuries.Add(bicepInjury);
            _context.Exercises.Add(arms9);

            //seed database with arms exercises
            var arms10 = new Exercise();
            arms10.Name = "Close grip bench press";
            //to filter Home workout or Gym workout or both home and gym workout
            arms10.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms10.Video = @"https://www.youtube.com/embed/43rg7fBNP2w";
            //Adds exercise to Injury group
            arms10.Injuries.Add(tricepInjury);
            _context.Exercises.Add(arms10);

            //seed database with arms exercises
            var arms11 = new Exercise();
            arms11.Name = "Dumbbell preacher curls";
            //to filter Home workout or Gym workout or both home and gym workout
            arms11.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms11.Video = @"https://www.youtube.com/embed/7oSbBVx73_c";
            //Adds exercise to Injury group
            arms11.Injuries.Add(bicepInjury);
            _context.Exercises.Add(arms11);

            //seed database with arms exercises
            var arms12 = new Exercise();
            arms12.Name = "Skull crusher";
            //to filter Home workout or Gym workout or both home and gym workout
            arms12.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            arms12.Video = @"https://www.youtube.com/embed/gTrlbuuMufQ";
            //Adds exercise to Injury group
            arms12.Injuries.Add(tricepInjury);
            _context.Exercises.Add(arms12);

            var arms13 = new Exercise();
            arms13.Name = "bench dips";
            //to filter Home workout or Gym workout or both home and gym workout
            arms13.Description = "Home";
            //The video link to guide the user how to perform the exercise
            arms13.Video = @"https://www.youtube.com/embed/S8vL5DK04fU";
            //Adds exercise to Injury group
            arms13.Injuries.Add(tricepInjury);
            _context.Exercises.Add(arms13);

            var arms14 = new Exercise();
            arms14.Name = "Hindu Push ups";
            //to filter Home workout or Gym workout or both home and gym workout
            arms14.Description = "Home";
            //The video link to guide the user how to perform the exercise
            arms14.Video = @"https://www.youtube.com/embed/vB6ZR_wl9bQ";
            //Adds exercise to Injury group

            _context.Exercises.Add(arms14);


/*----------------------------------------------------------------------------*/

            
            //Shoulders Exercises


            //seed database with shoulders exercises
            var shoulders1 = new Exercise();
            shoulders1.Name = "Overhead shoulder press";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders1.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders1.Video = @"https://www.youtube.com/shorts/DN3WXJlB1Q4";
            //Adds exercise to Injury group
            shoulders1.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders1);

            //seed database with shoulders exercises
            var shoulders2 = new Exercise();
            shoulders2.Name = "Rear delt raises";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders2.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders2.Video = @"https://www.youtube.com/shorts/9bERtRKo4UY";
            //Adds exercise to Injury group
            shoulders2.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders2);

            //seed database with shoulders exercises
            var shoulders3 = new Exercise();
            shoulders3.Name = "Dumbbell Lateral Raises";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders3.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders3.Video = @"https://www.youtube.com/shorts/JIhbYYA1Q90";
            //Adds exercise to Injury group
            shoulders3.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders3);

            //seed database with shoulders exercises
            var shoulders4 = new Exercise();
            shoulders4.Name = "Single arm cable lateral raise";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders4.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders4.Video = @"https://www.youtube.com/shorts/1AmmsXlf8MU";
            //Adds exercise to Injury group
            shoulders4.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders4);

            //seed database with shoulders exercises
            var shoulders5 = new Exercise();
            shoulders5.Name = "Dumbbell front Raise";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders5.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders5.Video = @"https://www.youtube.com/shorts/yHx8wPv4RPo";
            //Adds exercise to Injury group
            shoulders5.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders5);

            //seed database with shoulders exercises
            var shoulders6 = new Exercise();
            shoulders6.Name = "Barbell front raise";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders6.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders6.Video = @"https://www.youtube.com/shorts/PqAUOn-RmFA";
            //Adds exercise to Injury group
            shoulders6.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders6);

            //seed database with shoulders exercises
            var shoulders7 = new Exercise();
            shoulders7.Name = "Upright row";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders7.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders7.Video = @"https://www.youtube.com/shorts/KAEE2N4YnBE";
            //Adds exercise to Injury group
            shoulders7.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders7);

            //seed database with shoulders exercises
            var shoulders8 = new Exercise();
            shoulders8.Name = "Face pull";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders8.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders8.Video = @"https://www.youtube.com/shorts/LJN-sT_6OYY";
            //Adds exercise to Injury group
            shoulders8.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders8);

            //seed database with shoulders exercises
            var shoulders9 = new Exercise();
            shoulders9.Name = "Arnold press";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders9.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders9.Video = @"https://www.youtube.com/shorts/ppVR9oF32K0";
            //Adds exercise to Injury group
            shoulders9.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders9);

            //seed database with shoulders exercises
            var shoulders10 = new Exercise();
            shoulders10.Name = "Reverse Machine flyes";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders10.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            shoulders10.Video = @"https://www.youtube.com/shorts/TxoDSfcObdU";
            //Adds exercise to Injury group
            shoulders10.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders10);

            //seed database with shoulders exercises
            var shoulders11 = new Exercise();
            shoulders11.Name = "Pike push ups";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders11.Description = "Home";
            //The video link to guide the user how to perform the exercise
            shoulders11.Video = @"https://www.youtube.com/shorts/RmKUhj62_9c";
            //Adds exercise to Injury group
            shoulders11.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders11);

            //seed database with shoulders exercises
            var shoulders12 = new Exercise();
            shoulders12.Name = "wall assisted handstand push ups";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders12.Description = "Home";
            //The video link to guide the user how to perform the exercise
            shoulders12.Video = @"https://www.youtube.com/shorts/6446ZMlWpqI";
            //Adds exercise to Injury group
            shoulders12.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders12);

            //seed database with shoulders exercises
            var shoulders13 = new Exercise();
            shoulders13.Name = "Handstand push ups";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders13.Description = "Home";
            //The video link to guide the user how to perform the exercise
            shoulders13.Video = @"https://www.youtube.com/shorts/q5sbqedk5tc";
            //Adds exercise to Injury group
            shoulders13.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders13);


            //seed database with shoulders exercises
            var shoulders14 = new Exercise();
            shoulders14.Name = "wall assisted handstand Holds";
            //to filter Home workout or Gym workout or both home and gym workout
            shoulders14.Description = "Home";
            //The video link to guide the user how to perform the exercise
            shoulders14.Video = @"https://www.youtube.com/shorts/xBM-qIgkk6E";
            //Adds exercise to Injury group
            shoulders14.Injuries.Add(shoulderInjury);
            _context.Exercises.Add(shoulders14);

/*----------------------------------------------------------------------------*/
            
            //Legs Exercises


            //seed database with legs exercises
            var legs1 = new Exercise();
            legs1.Name = "bodyweight Squats";
            //to filter Home workout or Gym workout or both home and gym workout
            legs1.Description = "Home";
            //The video link to guide the user how to perform the exercise
            legs1.Video = @"https://www.youtube.com/shorts/I7Nk1RMtcLs";
            //Adds exercise to Injury group
            legs1.Injuries.Add(legInjury);
            _context.Exercises.Add(legs1);

            //seed database with legs exercises
            var legs2 = new Exercise();
            legs2.Name = "Barbell back squat";
            //to filter Home workout or Gym workout or both home and gym workout
            legs2.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            legs2.Video = @"https://www.youtube.com/shorts/gslEzVggur8";
            //Adds exercise to Injury group
            legs2.Injuries.Add(legInjury);
            _context.Exercises.Add(legs2);

            //seed database with legs exercises
            var legs3 = new Exercise();
            legs3.Name = "Barbell front squat";
            //to filter Home workout or Gym workout or both home and gym workout
            legs3.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            legs3.Video = @"https://www.youtube.com/shorts/yq7MQCWMgg8";
            //Adds exercise to Injury group
            legs3.Injuries.Add(legInjury);
            _context.Exercises.Add(legs3);

            //seed database with legs exercises
            var legs4 = new Exercise();
            legs4.Name = "leg press";
            //to filter Home workout or Gym workout or both home and gym workout
            legs4.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            legs4.Video = @"https://www.youtube.com/shorts/ahaJTts1f3s";
            //Adds exercise to Injury group
            legs4.Injuries.Add(legInjury);
            _context.Exercises.Add(legs4);

            //seed database with legs exercises
            var legs5 = new Exercise();
            legs5.Name = "leg extention";
            //to filter Home workout or Gym workout or both home and gym workout
            legs5.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            legs5.Video = @"https://www.youtube.com/shorts/D1Zn0mBw4DE";
            //Adds exercise to Injury group
            legs5.Injuries.Add(legInjury);
            _context.Exercises.Add(legs5);

            //seed database with legs exercises
            var legs6 = new Exercise();
            legs6.Name = "hamstring curl";
            //to filter Home workout or Gym workout or both home and gym workout
            legs6.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            legs6.Video = @"https://www.youtube.com/shorts/HeNjxoJhyow";
            //Adds exercise to Injury group
            legs6.Injuries.Add(legInjury);
            _context.Exercises.Add(legs6);

            //seed database with legs exercises
            var legs7 = new Exercise();
            legs7.Name = "split squat";
            //to filter Home workout or Gym workout or both home and gym workout
            legs7.Description = "both home and gym workout";
            //The video link to guide the user how to perform the exercise
            legs7.Video = @"https://www.youtube.com/shorts/bwhl_9jN_3o";
            //Adds exercise to Injury group
            legs7.Injuries.Add(legInjury);
            _context.Exercises.Add(legs7);

            //seed database with legs exercises
            var legs8 = new Exercise();
            legs8.Name = "Dumbbell romanian deadlift";
            //to filter Home workout or Gym workout or both home and gym workout
            legs8.Description = "Gym workout";
            //The video link to guide the user how to perform the exercise
            legs8.Video = @"https://www.youtube.com/shorts/eHLuROg0FSI";
            //Adds exercise to Injury group
            legs8.Injuries.Add(legInjury);
            _context.Exercises.Add(legs8);

            //seed database with legs exercises
            var legs9 = new Exercise();
            legs9.Name = "calf raises";
            //to filter Home workout or Gym workout or both home and gym workout
            legs9.Description = "both home and gym workout";
            //The video link to guide the user how to perform the exercise
            legs9.Video = @"https://www.youtube.com/shorts/fOfPwmb5FXU";
            //Adds exercise to Injury group
            legs9.Injuries.Add(legInjury);
            _context.Exercises.Add(legs9);

            //seed database with legs exercises
            var legs10 = new Exercise();
            legs10.Name = "Bulgarian squat";
            //to filter Home workout or Gym workout or both home and gym workout
            legs10.Description = "both home and gym workout";
            //The video link to guide the user how to perform the exercise
            legs10.Video = @"https://www.youtube.com/shorts/uODWo4YqbT8";
            //Adds exercise to Injury group
            legs10.Injuries.Add(legInjury);
            _context.Exercises.Add(legs10);
            
            

            _context.SaveChanges();
            
        }
    }
}

