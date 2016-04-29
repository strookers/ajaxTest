using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiTest.Models;

namespace MultiTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Student> sList = new List<Student>();
            sList.Add(new Student { Name = "Ole", Age = 23 });
            sList.Add(new Student { Name = "Bo", Age = 21 });
            sList.Add(new Student { Name = "Bob", Age = 22 });

            List<object> modelList = new List<object>();
            modelList.Add(sList);
            modelList.Add(new Page {Title = "Forside", Text = "Velkommen til min forside.. bla bla bla bla bla"});
            return View(modelList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult StudentInfo(Student student)
        {
            ViewBag.Message = "Your contact page.";
            Page page = new Page {Title = "StudentInfo", Text = "Velkommen til student info.. bla bla bla bla bla"};

            List<object> modelList = new List<object>();
            modelList.Add(student);
            modelList.Add(page);
            return View(modelList);
        }
    }
}