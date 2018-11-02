using System;
using Microsoft.AspNetCore.Mvc;

namespace RazorPractice
{

    public class HomeController : Controller
    {

        [HttpGet ("")]

        public ViewResult Index ()
        {
            return View();
        }
    }

}