using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RWG.Context;

namespace RWG.Controllers
{
	public class ProgressController : Controller
	{
        private readonly DatabaseContext _context;

        public ProgressController(DatabaseContext context)
		{
			_context = context;
		}

		// returns the Progress for each exercise
		public IActionResult ExerciseProgress(int workoutId, int exerciseId)
		{
            // takes the exercises id that matches with the workout id
            // and should add them and order them by date in a descending order
            // the progress includes the workout id
            // and includes the Exericise id
            // both should be matching

            // Retrieve a collection of Progress objects from the database
            var progresses = _context.Progresses
                // Include related data for the Workout navigation property
                .Include(progress => progress.Workout)
                // Include related data for the Exercise navigation property
                .Include(progress => progress.Exercise)
                // Filter the Progresses based on Workout and Exercise IDs
                .Where(progress => progress.Workout.Id == workoutId && progress.Exercise.Id == exerciseId)
                // Order the Progresses by Date in descending order
                .OrderByDescending(progress => progress.Date)
                // Convert the result to an IQueryable (useful for further query operations)
                .AsQueryable();

            // Pass the collection of Progresses to the view
            return View(progresses);

        }

        // does the same for the ExerciseProgress method
        //returns progress for exercises but for the Workout as a Whole not just one exercise
        public IActionResult WorkoutList(int workoutId)
        {
            // Retrieve a collection of Progress objects from the database
            var progresses = _context.Progresses
                // Include related data for the Workout navigation property
                .Include(progress => progress.Workout)
                // Include related data for the Exercise navigation property
                .Include(progress => progress.Exercise)
                // Filter the Progresses based on Workout ID
                .Where(progress => progress.Workout.Id == workoutId)
                // Order the Progresses by Date in descending order
                .OrderByDescending(progress => progress.Date)
                // Convert the result to an IQueryable (useful for further query operations)
                .AsQueryable();

            // Pass the collection of Progresses to the view
            return View(progresses);

        }
    }
}

