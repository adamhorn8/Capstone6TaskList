using Capstone6TaskList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone6TaskList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchTask()
        {
            return View();
        }

        public ActionResult SearchResult(int ID)
        {
            TaskListEntities ORM = new TaskListEntities();

            ViewBag.Task = ORM.Tasks.Where(x => x.UserID == ID).ToList();

            return View();
        }

    }
}