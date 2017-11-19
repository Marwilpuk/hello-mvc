using HelloMVC.Models;
using HelloMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        private JobsService jobsService;

        public HomeController()
        {
            jobsService = new JobsService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            SetFields(ViewBag);

            return View();
        }

        public ActionResult Jobs()
        {
            ViewBag.Message = "Open positions";
            
            JobsViewModel jobOpeningsColelctions = new JobsViewModel
            {
                ApplyEndDate = new DateTime(2017, 12, 31).ToString(),
                EngineeringJobs = jobsService.GetEngineeringJobOpenings(),
                Internships = jobsService.GetInternships()
            };

            return View(jobOpeningsColelctions);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private void SetFields (dynamic arg)
        {
            arg.MyMessage1 = "Bla bla message 1";
            arg.MyMessage2 = "Bla bla message 2";
            arg.MyMessage3 = "Bla bla message 3";
        }
    }
}