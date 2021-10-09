using Microsoft.AspNetCore.Mvc;
using RetroArcade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroArcade.Controllers
{
    public class SignInController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignIn(SignInModel signInModel)
        {
            
            return RedirectToAction("Index", "Home" );
        }
    }
}
