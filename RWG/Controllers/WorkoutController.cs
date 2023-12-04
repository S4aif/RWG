using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RWG.Context;
using RWG.Models;

namespace RWG.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly DatabaseContext _context;
        public WorkoutController(DatabaseContext context)
        {
            _context = context;
        }




        public IActionResult Workout()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            //using HttpGet to get the properties from Workout class

            var model = new Workout();
            return View(model);

            //return View();

        }


        [HttpPost]
        public IActionResult Create(Workout viewModel)
        {

            // Retrieve selected injuries
            var Injuries = viewModel.Injuries; // Assuming you have a property like this in the ViewModel

            // Filter exercises based on selected injuries
            var filteredExercises = _context.Exercises.Where(exercise => !Injuries.Any(injury => exercise.Injuries.Contains(injury))).ToList();

            // Create workout with filtered exercises
            var workout = new Workout();
            workout.Exercises = filteredExercises;

            // Save the workout
            _context.Workouts.Add(workout);
            _context.SaveChanges();


            // Redirect or return a view as needed
            return RedirectToAction("Saved");   
        }


        public IActionResult Saved()
        {
            return View();
        }

    }
}

