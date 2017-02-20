using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teploset.Controllers
{
    public class VacancyController : Controller
    {
        // GET: Vacancy
        public ActionResult Index(string id)
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            return View();
        }
    }
}