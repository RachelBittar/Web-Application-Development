using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class1.Models;

namespace Class1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()  //I am instructing MVC to render a viewI am instructing MVC to render a view
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View("MyView"); //Nome da minha view
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // TODO: store response from guest
            return View();
        }

        /*     public IActionResult About()
             {
                 ViewData["Message"] = "Your application description page.";

                 return View();
             }

             public IActionResult Contact()
             {
                 ViewData["Message"] = "Your contact page.";

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
             */
    }
}
