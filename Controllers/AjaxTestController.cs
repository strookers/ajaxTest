using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiTest.Controllers
{
    public class AjaxTestController : Controller
    {
        // GET: /AjaxTest/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Test(string[] value)
        {
            // call and return a string
            string test = "Du valgte: ";

            foreach (string c in value)
            {
                test += c + ", ";
            }
            test = test.TrimEnd(' ', ',');
            return test;
        }
    }
}