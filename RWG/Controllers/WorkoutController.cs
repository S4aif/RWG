using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RWG.Context;
using RWG.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace RWG.Controllers
{
    [Authorize]
    public class WorkoutController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;

        public WorkoutController(DatabaseContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public IActionResult Workout()
        {
            return View();
        }


//--------------------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult Create()
        {
            //using HttpGet to get the properties from Workout class
            var injuries = _context.Injuries.OrderBy(injury => injury.Name).ToList();
            return View(injuries);

            //return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(WorkoutViewModel viewModel)
        {
            // null workout properties?
            if (!ModelState.IsValid)
            {
                // Model state is invalid, return the view with validation errors
                return View(viewModel);
            }

            //taking the injuries in the database 
            var injuries = new List<Injury>();

            //method of the list of injuries to be used in the form and process them
            //Injury one
            if (viewModel.Injury1 != 0)
                injuries.Add(_context.Injuries.Single(injury => viewModel.Injury1 == injury.Id));

            //Injury two
            if (viewModel.Injury2 != 0)
                injuries.Add(_context.Injuries.Single(injury => viewModel.Injury2 == injury.Id));

            //Injury three
            if (viewModel.Injury3 != 0)
                injuries.Add(_context.Injuries.Single(injury => viewModel.Injury3 == injury.Id));

            //Injury four
            if (viewModel.Injury4 != 0)
                injuries.Add(_context.Injuries.Single(injury => viewModel.Injury4 == injury.Id));

            //Injury five
            if (viewModel.Injury5 != 0)
                injuries.Add(_context.Injuries.Single(injury => viewModel.Injury5 == injury.Id));


            //Injury six
            if (viewModel.Injury6 != 0)
                injuries.Add(_context.Injuries.Single(injury => viewModel.Injury6 == injury.Id));

            // Filter exercises based on selected injuries
            var exercises = _context.Exercises.Include(exercise => exercise.Injuries).ToList();
            var filteredExercises = exercises.Where(exercise => !injuries.Any(injury => exercise.Injuries.Contains(injury))).ToList();

            // Create workout with filtered exercises
            var workout = new Workout();

            //saves the safe excercises that excluded the injuries to the filteredExercises variable
            workout.Exercises = filteredExercises;


            // Create a new instance of the Random class to generate random numbers
            var random = new Random();

            // Shuffle the order of exercises in the filteredExercises list using a random order
            var shuffledExercises = filteredExercises.OrderBy(x => random.Next()).ToList();

            // Define the number of random exercises to select
            int rndExercisesNum = 10;

            // Take the specified number of exercises from the shuffled list and assign them to the workout
            workout.Exercises = shuffledExercises.Take(rndExercisesNum).ToList();

            // Assign a name to the workout
            workout.Name = "My Workout";


            //assigns the workout created to the user logged in
            workout.User = await _userManager.FindByNameAsync(User!.Identity!.Name);

            // Save the new filtered Workout
            _context.Workouts.Add(workout);
            _context.SaveChanges();


            // Redirect the user to their created workouts
            return RedirectToAction("Saved");
        }

//--------------------------------------------------------------------------------------------------------------------------------------------

        //the saved workouts page
        public IActionResult Saved()
        {
            //fetches the saved workouts that were created from the database to the page
            var workouts = _context.Workouts.Include(list => list.User).AsQueryable();
            return View(workouts);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
        // to edit the workout's name
        public IActionResult Edit(int id)
        {
            // Retrieve the workout with its exercises from the database
            var workout = _context.Workouts.Include(workout => workout.Exercises)
                .SingleOrDefault(workout => workout.Id == id);

            // Check if the workout is not found
            if (workout == null)
                return RedirectToAction("Saved", "Workout");

            // Render the Edit view with the workout details
            return View(workout);
        }

        //To delete the saved workout from the database and the website
        public IActionResult Delete(int id)
        {
            // get the reminder from the database
            var workout = _context.Workouts.Include(workout => workout.Exercises)
                .SingleOrDefault(workout => workout.Id == id);
            if (workout == null)
                return RedirectToAction("Saved", "Workout");

            // delete it from the database
            _context.Workouts.Remove(workout);
            _context.SaveChanges();

            //shows the user the new saved workouts page
            //after the changes after it deleted it by Id
            return RedirectToAction("Saved", new { workout.Id });
        }

        [HttpGet]
        // Add the progress of the user whilst doing the workout
        public IActionResult StartExercise(int id)
        {
            // to add the workout to the viewModel and pass it on to the model in AddProgress.cshtml
            var workout = _context.Workouts.Include(workout => workout.Exercises).SingleOrDefault(workout => workout.Id == id);

            return View(workout);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //to save the changes updated for the workouts
        [HttpPost]
        public IActionResult UpdateWorkout(EditWorkoutViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Saved", "Workout");

            // get the workout by workout id
            var workout = _context.Workouts.Include(workout => workout.Exercises).SingleOrDefault(workout => workout.Id == viewModel.WorkoutId);
            if (workout == null)
                return RedirectToAction("Saved", "Workout");

            // change the fields of the workout
            workout.Name = viewModel.Name;

            // save the edit to the database
            _context.Workouts.Update(workout);
            _context.SaveChanges();

            //shows the user the new saved workouts page after the changes after it changed it by Name
            return RedirectToAction("Saved", new { workout.Name });
        }

        public IActionResult AddProgress(int exerciseId, int workoutId)
        {
            // define the new workout variable and link it to workout id
            var workout = _context.Workouts.Include(workout => workout.Exercises).Single(workout => workout.Id == workoutId);
            // define the new exercise variable and link it to exercise id
            var exercise = workout.Exercises.Single(exercise => exercise.Id == exerciseId);
            // add the ProgressViewModel (exercise and workout), to the viewModel
            var viewModel = new ProgressViewModel { Exercise = exercise, Workout = workout };

            return View(viewModel);


        }


        [HttpPost]
        public async Task<IActionResult> AddProgressAsync(AddProgressViewModel viewModel)
        {
            // link progress inputted to the workout's id
            var workout = _context.Workouts.Include(workout => workout.Exercises).Single(workout => workout.Id == viewModel.WorkoutId);
            // link progress inputted to the exercise's id
            var exercise = workout.Exercises.Single(exercise => exercise.Id == viewModel.ExerciseId);
            // add the progress to the user
            var user = await _userManager.FindByNameAsync(User!.Identity!.Name);

            // create it as a new progress variable
            var progress = new Progress();
            progress.Date = DateTime.Now;
            progress.Exercise = exercise;
            progress.Workout = workout;
            progress.Reps = viewModel.Reps;
            progress.Set = viewModel.Set;
            progress.Weight = viewModel.Weight;
            progress.User = user;

            // add it to the database
            _context.Progresses.Add(progress);
            await _context.SaveChangesAsync();

            return RedirectToAction("StartExercise", "Workout", new { id = viewModel.WorkoutId });
        }
    }
}

