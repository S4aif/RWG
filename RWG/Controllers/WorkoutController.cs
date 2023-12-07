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
            workout.Name = "My Workout";
            //assigns the workout created to the user logged in
            workout.User = await _userManager.FindByNameAsync(User!.Identity!.Name);

            // Save the new filtered Workout
            _context.Workouts.Add(workout);
            _context.SaveChanges();


            // Redirect the user to their created workouts
            return RedirectToAction("Saved");

        }



        public IActionResult Saved()
        {
            return View();
        }

    }
}

