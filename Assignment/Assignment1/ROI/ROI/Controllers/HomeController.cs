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
            if (ModelState.IsValid) //validate
            {
                Repository.AddResponse(userdatas);
                return View("Thanks", userdatas.Name);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}
