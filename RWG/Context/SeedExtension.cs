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

			var password = "S4aif2447!";
			_ = _userManager.CreateAsync(user, password);


/*----------------------------------------------------------------------------*/
               //Chest Exercises


            //seed database with chest exercises
            var chest1 = new Exercise();
			chest1.Name = "Barbell Bench Press";
            //to filter home workout or gym or both
            chest1.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest1.Video = @"https://youtube.com/shorts/VXjPjzEjRSU?si=C5Yn8pI0lElfkyKf";
            _context.Exercises.Add(chest1);

            //seed database with chest exercises
            var chest2 = new Exercise();
            chest2.Name = "Dumbbell Bench Press";
            //to filter home workout or gym or both
            chest2.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest2.Video = @"https://youtube.com/shorts/1V3vpcaxRYQ?si=lmAVMrjXgiP389a1";
            _context.Exercises.Add(chest2);

            //seed database with chest exercises
            var chest3 = new Exercise();
            chest3.Name = "Barbell Incline Bench Press";
            //to filter home workout or gym or both
            chest3.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest3.Video = @"https://youtube.com/shorts/cq-4gME3IFY?si=BHDVCDVtDf4qdCQo";
            _context.Exercises.Add(chest3);

            //seed database with chest exercises
            var chest4 = new Exercise();
            chest4.Name = "Dumbbell Incline Bench Press";
            //to filter home workout or gym or both
            chest4.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest4.Video = @"https://youtube.com/shorts/Gruq177Psnk?si=VYdmiTfFC_OC57R5";
            _context.Exercises.Add(chest4);

            //seed database with chest exercises
            var chest5 = new Exercise();
            chest5.Name = "Dumbbell Flyes";
            //to filter home workout or gym or both
            chest5.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest5.Video = @"https://youtube.com/shorts/J49byaRpuMw?si=uxqNo3VoeGO-2QRt";
            _context.Exercises.Add(chest5);

            //seed database with chest exercises
            var chest6 = new Exercise();
            chest6.Name = "Cable crossover";
            //to filter home workout or gym or both
            chest6.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest6.Video = @"https://youtube.com/shorts/6NM7oplcqtU?si=hb8A-NdtgGJ0rOS3";
            _context.Exercises.Add(chest6);

            //seed database with chest exercises
            var chest7 = new Exercise();
            chest7.Name = "Parallel bar dips";
            //to filter home workout or gym or both
            chest7.Description = "Both";
            //The video link to guide the user how to perform the exercise
            chest7.Video = @"https://youtube.com/shorts/1_4OICx2WrY?si=MGlo_R_ihG9B9DtK";
            _context.Exercises.Add(chest7);

            //seed database with chest exercises
            var chest8 = new Exercise();
            chest8.Name = "Machine Fly";
            //to filter home workout or gym or both
            chest8.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest8.Video = @"https://youtube.com/shorts/NEXwXAJ3D2A?si=jr32Bls623u7Ijd5";
            _context.Exercises.Add(chest8);

            //seed database with chest exercises
            var chest9 = new Exercise();
            chest9.Name = "Close Grip Bench Press";
            //to filter home workout or gym or both
            chest9.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest9.Video = @"https://youtube.com/shorts/VYC2QZEOIUI?si=LwYUMgJSih-1ALEZ";
            _context.Exercises.Add(chest9);

            //seed database with chest exercises
            var chest10 = new Exercise();
            chest10.Name = "High to low cable flyes";
            //to filter home workout or gym or both
            chest10.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest10.Video = @"https://youtube.com/shorts/kHs4cHcu5b0?si=OHlbaboSEtkeGnxC";
            _context.Exercises.Add(chest10);

            //seed database with chest exercises
            var chest11 = new Exercise();
            chest11.Name = "Low to High cable Flyes";
            //to filter home workout or gym or both
            chest11.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest11.Video = @"https://youtube.com/shorts/ZWa8v57fCZ8?si=3IfdnETw8ytt1UBj";
            _context.Exercises.Add(chest11);

            //seed database with chest exercises
            var chest12 = new Exercise();
            chest12.Name = "Push ups";
            //to filter home workout or gym or both
            chest12.Description = "Home";
            //The video link to guide the user how to perform the exercise
            chest12.Video = @"https://youtube.com/shorts/yQEx9OC2C3E?si=Rt5OvAB3-T6mp2Ni";
            _context.Exercises.Add(chest12);

            //seed database with chest exercises
            var chest13 = new Exercise();
            chest13.Name = "Incline Push ups";
            //to filter home workout or gym or both
            chest13.Description = "Home";
            //The video link to guide the user how to perform the exercise
            chest13.Video = @"https://youtube.com/shorts/Mc-Kdwnx_M8?si=wU-N6hE17wdB7k5I";
            _context.Exercises.Add(chest13);

            //seed database with chest exercises
            var chest14 = new Exercise();
            chest14.Name = "Decline Push ups";
            //to filter home workout or gym or both
            chest14.Description = "Home";
            //The video link to guide the user how to perform the exercise
            chest14.Video = @"https://youtube.com/shorts/dcV-ATSeryA?si=DdWr-IBkB1uDZ48l";
            _context.Exercises.Add(chest14);

            //seed database with chest exercises
            var chest15 = new Exercise();
            chest15.Name = "Dumbbell Pullover";
            //to filter home workout or gym or both
            chest15.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            chest15.Video = @"https://youtube.com/shorts/raU5C9bWo9U?si=RMbkoOcXx8YeZCyg";
            _context.Exercises.Add(chest15);

            //seed database with chest exercises
            var chest16 = new Exercise();
            chest16.Name = "Explosive push ups";
            //to filter home workout or gym or both
            chest16.Description = "Home";
            //The video link to guide the user how to perform the exercise
            chest16.Video = @"https://youtube.com/shorts/jXNILmxCVxU?si=_LHBdBnxK7uubwpk";
            _context.Exercises.Add(chest16);

/*----------------------------------------------------------------------------*/

            //Back Exercises


            //seed database with back exercises
            var back1 = new Exercise();
            back1.Name = "Dumbbell Row";
            //to filter home workout or gym or both
            back1.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back1.Video = @"https://youtube.com/shorts/GDrJlDB0isk?si=1VUE-SH7hehT-PBW";
            _context.Exercises.Add(back1);

            //seed database with back exercises
            var back2 = new Exercise();
            back2.Name = "Lat Pulldown";
            //to filter home workout or gym or both
            back2.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back2.Video = @"https://youtube.com/shorts/77bPLrsMwiQ?si=5agNaukHK4AzJwiP";
            _context.Exercises.Add(back2);

            //seed database with back exercises
            var back3 = new Exercise();
            back3.Name = "bent over row";
            //to filter home workout or gym or both
            back3.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back3.Video = @"https://youtube.com/shorts/DgyslsszCQ0?si=vviR1Nk5RVZqf_Cu";
            _context.Exercises.Add(back3);

            //seed database with back exercises
            var back4 = new Exercise();
            back4.Name = "pull up";
            //to filter home workout or gym or both
            back4.Description = "Both";
            //The video link to guide the user how to perform the exercise
            back4.Video = @"https://youtube.com/shorts/dvG8B2OjfWk?si=7hDRSHTXondvAYM3";
            _context.Exercises.Add(back4);

            //seed database with back exercises
            var back5 = new Exercise();
            back5.Name = "seated cable row";
            //to filter home workout or gym or both
            back5.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back5.Video = @"https://youtube.com/shorts/z7C7PxVDAD0?si=Xt0OP8wxC_N5Cdpq";
            _context.Exercises.Add(back5);

            //seed database with back exercises
            var back6 = new Exercise();
            back6.Name = "Dumbbell pullover";
            //to filter home workout or gym or both
            back6.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back6.Video = @"https://youtube.com/shorts/raU5C9bWo9U?si=RMbkoOcXx8YeZCyg";
            _context.Exercises.Add(back6);

            //seed database with back exercises
            var back7 = new Exercise();
            back7.Name = "straight arm pulldown";
            //to filter home workout or gym or both
            back7.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back7.Video = @"https://youtube.com/shorts/1_E77qhMpkE?si=zeKzhZ_3TEAeo3S4";
            _context.Exercises.Add(back7);

            //seed database with back exercises
            var back8 = new Exercise();
            back8.Name = "Dumbbell Shrugs";
            //to filter home workout or gym or both
            back8.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back8.Video = @"https://youtube.com/shorts/R3FLhX81MYg?si=_o-UNxxV6TeePf0R";
            _context.Exercises.Add(back8);

            //seed database with back exercises
            var back9 = new Exercise();
            back9.Name = "Barbell Shrugs";
            //to filter home workout or gym or both
            back9.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back9.Video = @"https://youtube.com/shorts/MlqHEfydPpE?si=3oZzLpvmwRQJmRNY";
            _context.Exercises.Add(back9);

            //seed database with back exercises
            var back10 = new Exercise();
            back10.Name = "Wide grip pull up";
            //to filter home workout or gym or both
            back10.Description = "Both";
            //The video link to guide the user how to perform the exercise
            back10.Video = @"https://youtube.com/shorts/NwrJk3AWX50?si=YvjkI3X9UIIlRnkQ";
            _context.Exercises.Add(back10);

            //seed database with back exercises
            var back11 = new Exercise();
            back11.Name = "supermans";
            //to filter home workout or gym or both
            back11.Description = "Home";
            //The video link to guide the user how to perform the exercise
            back11.Video = @"https://youtube.com/shorts/KTWWh3GsyYw?si=J-2YSzIW81zskB2M";
            _context.Exercises.Add(back11);

            //seed database with back exercises
            var back12 = new Exercise();
            back12.Name = "face pull";
            //to filter home workout or gym or both
            back12.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back12.Video = @"https://youtube.com/shorts/LJN-sT_6OYY?si=0dx1zDo8HshfOgvI";
            _context.Exercises.Add(back12);

            //seed database with back exercises
            var back13 = new Exercise();
            back13.Name = "T-bar row";
            //to filter home workout or gym or both
            back13.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back13.Video = @"https://youtube.com/shorts/8c23NBbwLBc?si=MFsv37P6mkWnyu1l";
            _context.Exercises.Add(back13);

            //seed database with back exercises
            var back14 = new Exercise();
            back14.Name = "One arm lat pull down";
            //to filter home workout or gym or both
            back14.Description = "Gym";
            //The video link to guide the user how to perform the exercise
            back14.Video = @"https://youtube.com/shorts/wYy32uk4Bu8?si=8k2YE6LBcdEvZI_P";
            _context.Exercises.Add(back14);

            /*----------------------------------------------------------------------------*/


            //Arms Exercises

            //seed database with arms exercises
            var arms1 = new Exercise();
            arms1.Name = "Bicep curl";
            //to filter home workout or gym or both
            arms1.Description = "Gym";
            _context.Exercises.Add(arms1);

            //seed database with arms exercises
            var arms2 = new Exercise();
            arms2.Name = "Hammer curl";
            //to filter home workout or gym or both
            arms2.Description = "Gym";
            arms1.Video = @"";
            _context.Exercises.Add(arms2);

            var arms3 = new Exercise();
            arms3.Name = "Tricep dips";
            //to filter home workout or gym or both
            arms3.Description = "Gym";
            _context.Exercises.Add(arms3);

            //seed database with arms exercises
            var arms4 = new Exercise();
            arms4.Name = "Overhead tricep extension";
            //to filter home workout or gym or both
            arms4.Description = "Gym";
            _context.Exercises.Add(arms4);

            //seed database with arms exercises
            var arms5 = new Exercise();
            arms5.Name = "Cable tricep kickback";
            //to filter home workout or gym or both
            arms5.Description = "Gym";
            _context.Exercises.Add(arms5);

            //seed database with arms exercises
            var arms6 = new Exercise();
            arms6.Name = "Tricep pushdown";
            //to filter home workout or gym or both
            arms6.Description = "Gym";
            _context.Exercises.Add(arms6);

            //seed database with arms exercises
            var arms7 = new Exercise();
            arms7.Name = "Diamond pushups";
            //to filter home workout or gym or both
            arms7.Description = "Home";
            _context.Exercises.Add(arms7);

            //seed database with arms exercises
            var arms8 = new Exercise();
            arms8.Name = "Barbell curl";
            //to filter home workout or gym or both
            arms8.Description = "Gym";
            _context.Exercises.Add(arms8);

            //seed database with arms exercises
            var arms9 = new Exercise();
            arms9.Name = "ez bar curl";
            //to filter home workout or gym or both
            arms9.Description = "Gym";
            _context.Exercises.Add(arms9);

            //seed database with arms exercises
            var arms10 = new Exercise();
            arms10.Name = "Close grip bench press";
            //to filter home workout or gym or both
            arms10.Description = "Gym";
            _context.Exercises.Add(arms10);

            //seed database with arms exercises
            var arms11 = new Exercise();
            arms11.Name = "Dumbbell preacher curls";
            //to filter home workout or gym or both
            arms11.Description = "Gym";
            _context.Exercises.Add(arms11);

            //seed database with arms exercises
            var arms12 = new Exercise();
            arms12.Name = "Skull crusher";
            //to filter home workout or gym or both
            arms12.Description = "Gym";
            _context.Exercises.Add(arms12);

            var arms13 = new Exercise();
            arms13.Name = "bench dips";
            //to filter home workout or gym or both
            arms13.Description = "Home";
            _context.Exercises.Add(arms13);

            var arms14 = new Exercise();
            arms14.Name = "Hindu Push ups";
            //to filter home workout or gym or both
            arms14.Description = "Home";
            _context.Exercises.Add(arms14);


            /*----------------------------------------------------------------------------*/


            //Shoulders Exercises


            //seed database with shoulders exercises
            var shoulders1 = new Exercise();
            shoulders1.Name = "Overhead shoulder press";
            //to filter home workout or gym or both
            shoulders1.Description = "Gym";
            _context.Exercises.Add(shoulders1);

            //seed database with shoulders exercises
            var shoulders2 = new Exercise();
            shoulders2.Name = "Rear delt raises";
            //to filter home workout or gym or both
            shoulders2.Description = "Gym";
            _context.Exercises.Add(shoulders2);

            //seed database with shoulders exercises
            var shoulders3 = new Exercise();
            shoulders3.Name = "Dumbbell Lateral Raises";
            //to filter home workout or gym or both
            shoulders3.Description = "Gym";
            _context.Exercises.Add(shoulders3);

            //seed database with shoulders exercises
            var shoulders4 = new Exercise();
            shoulders4.Name = "Single arm cable lateral raise";
            //to filter home workout or gym or both
            shoulders4.Description = "Gym";
            _context.Exercises.Add(shoulders4);

            //seed database with shoulders exercises
            var shoulders5 = new Exercise();
            shoulders5.Name = "Dumbbell front Raise";
            //to filter home workout or gym or both
            shoulders5.Description = "Gym";
            _context.Exercises.Add(shoulders5);

            //seed database with shoulders exercises
            var shoulders6 = new Exercise();
            shoulders6.Name = "Barbell front raise";
            //to filter home workout or gym or both
            shoulders6.Description = "Gym";
            _context.Exercises.Add(shoulders6);

            //seed database with shoulders exercises
            var shoulders7 = new Exercise();
            shoulders7.Name = "Upright row";
            //to filter home workout or gym or both
            shoulders7.Description = "Gym";
            _context.Exercises.Add(shoulders7);

            //seed database with shoulders exercises
            var shoulders8 = new Exercise();
            shoulders8.Name = "Face pull";
            //to filter home workout or gym or both
            shoulders8.Description = "Gym";
            _context.Exercises.Add(shoulders8);

            //seed database with shoulders exercises
            var shoulders9 = new Exercise();
            shoulders9.Name = "Arnold press";
            //to filter home workout or gym or both
            shoulders9.Description = "Gym";
            _context.Exercises.Add(shoulders9);

            //seed database with shoulders exercises
            var shoulders10 = new Exercise();
            shoulders10.Name = "Reverse Machine flyes";
            //to filter home workout or gym or both
            shoulders10.Description = "Gym";
            _context.Exercises.Add(shoulders10);

            //seed database with shoulders exercises
            var shoulders11 = new Exercise();
            shoulders11.Name = "Pike push ups";
            //to filter home workout or gym or both
            shoulders11.Description = "Home";
            _context.Exercises.Add(shoulders11);

            //seed database with shoulders exercises
            var shoulders12 = new Exercise();
            shoulders12.Name = "wall assisted handstand push ups";
            //to filter home workout or gym or both
            shoulders12.Description = "Home";
            _context.Exercises.Add(shoulders12);

            //seed database with shoulders exercises
            var shoulders13 = new Exercise();
            shoulders13.Name = "Handstand push ups";
            //to filter home workout or gym or both
            shoulders13.Description = "Home";
            _context.Exercises.Add(shoulders13);


            //seed database with shoulders exercises
            var shoulders14 = new Exercise();
            shoulders14.Name = "wall assisted handstand Holds";
            //to filter home workout or gym or both
            shoulders14.Description = "Home";
            _context.Exercises.Add(shoulders14);

/*----------------------------------------------------------------------------*/

            //Legs Exercises


            //seed database with legs exercises
            var legs1 = new Exercise();
            legs1.Name = "bodyweight Squats";
            //to filter home workout or gym or both
            legs1.Description = "Home";
            _context.Exercises.Add(legs1);

            //seed database with legs exercises
            var legs2 = new Exercise();
            legs2.Name = "Barbell back squat";
            //to filter home workout or gym or both
            legs2.Description = "Gym";
            _context.Exercises.Add(legs2);

            //seed database with legs exercises
            var legs3 = new Exercise();
            legs3.Name = "Barbell front squat";
            //to filter home workout or gym or both
            legs3.Description = "Gym";
            _context.Exercises.Add(legs3);

            //seed database with legs exercises
            var legs4 = new Exercise();
            legs4.Name = "leg press";
            //to filter home workout or gym or both
            legs4.Description = "Gym";
            _context.Exercises.Add(legs4);

            //seed database with legs exercises
            var legs5 = new Exercise();
            legs5.Name = "leg extention";
            //to filter home workout or gym or both
            legs5.Description = "Gym";
            _context.Exercises.Add(legs5);

            //seed database with legs exercises
            var legs6 = new Exercise();
            legs6.Name = "hamstring curl";
            //to filter home workout or gym or both
            legs6.Description = "Gym";
            _context.Exercises.Add(legs6);

            //seed database with legs exercises
            var legs7 = new Exercise();
            legs7.Name = "split squat";
            //to filter home workout or gym or both
            legs7.Description = "Both";
            _context.Exercises.Add(legs7);

            //seed database with legs exercises
            var legs8 = new Exercise();
            legs8.Name = "Dumbbell romanian deadlift";
            //to filter home workout or gym or both
            legs8.Description = "Gym";
            _context.Exercises.Add(legs8);

            //seed database with legs exercises
            var legs9 = new Exercise();
            legs9.Name = "calf raises";
            //to filter home workout or gym or both
            legs9.Description = "Both";
            _context.Exercises.Add(legs9);

            //seed database with legs exercises
            var legs10 = new Exercise();
            legs10.Name = "Bulgarian squat";
            //to filter home workout or gym or both
            legs10.Description = "Both";
            _context.Exercises.Add(legs10);

            _context.SaveChanges();
            
        }
    }
}

