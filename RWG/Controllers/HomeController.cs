using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RWG.Context;
using RWG.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;

namespace RWG.Controllers;

public class HomeController : Controller
{
    //read only because i dont want it to make any changes
    private readonly ILogger<HomeController> _logger;
    private readonly DatabaseContext _context;
    private readonly UserManager<User> _userManager;

    public HomeController(DatabaseContext context, UserManager<User> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
       // User user = await _userManager.FindByNameAsync(User!.Identity!.Name);

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }



   /* public ActionResult Index()
    {
        if (User.Identity.IsAuthenticated)
        {
            string FullName = User.Identity.Name;

        }
    } */
}


