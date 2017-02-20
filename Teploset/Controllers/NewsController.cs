using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teploset.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            ViewBag.Title = "Концерн&laquo;МТМ&raquo; | Новини";
            return View();
        }

        public ActionResult Details(Guid id)
        {
            ViewBag.Title = "Концерн&laquo;МТМ&raquo; | Новини";

            return View();
        }
    }
}