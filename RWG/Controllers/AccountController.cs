﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RWG.Models;


namespace RWG.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }


        public IActionResult Register()
        {
            return View();
        }
        
        //Register
        [HttpPost] //Retrieves the data entered by the user in the website
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            //checks if data provided is valid or not while registering
            if (!ModelState.IsValid)
                return RedirectToAction("Register");

            //checks if data entetred is the same as in "password" and "Confirm password" field
            if (viewModel.ConfirmPassword != viewModel.ConfirmPassword)
                return RedirectToAction("Register");

            //To save the user's data in the user variable
            var user = new User();
            user.UserName = viewModel.Email;
            user.Email = viewModel.Email;

            user.FirstName = viewModel.FirstName;
            user.Surname = viewModel.Surname;

            //If all checks have succeeded then User is redirected to Login page
            var result = await _userManager.CreateAsync(user, viewModel.Password);
            if (result.Succeeded)
                return RedirectToAction("Login");

        //Otherwise, keeps the user in the Register page
            return RedirectToAction("Register");
        }

        public IActionResult Login()
        {
            return View();
        }
        

        //Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            //checks if data provided is valid or not while logging in
            if (!ModelState.IsValid)
                return RedirectToAction("Login");

            //checks whether the email entered in the login page matches the one that was registered
            var user = await _userManager.FindByEmailAsync(viewModel.Email);
            //if the user left it blank, they are going to be sent back to login page again
            if (user == null)
                return RedirectToAction("Login");

            await _signInManager.SignOutAsync();

            var result = await _signInManager.PasswordSignInAsync(user, viewModel.Password, false, false);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Login");
        }

        //when a new login happens, it logs out any device that was logged in before 
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

