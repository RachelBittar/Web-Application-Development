using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ROI.Models;

namespace ROI.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
          //  int hour = DateTime.Now.Hour;
            String sdate = DateTime.Now.ToString("mm/dd/yyyy HH:mm:ss");
            ViewBag.GreetingHour = sdate;

            return View("WelcomeView"); //Main view      
        }
        [HttpGet]
        public ViewResult DataReplyForm()  //Action
        {
            return View();
        }

        [HttpPost]
        public ViewResult DataReplyForm(UserDatas userdatas)  //Action
        {
            return View("Thanks", userdatas);
        }
        //public IActionResult Contact() //Action
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
