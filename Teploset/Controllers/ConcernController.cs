using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teploset.EF;
using Teploset.EF.Classes;
using Teploset.Models;
using Teploset.Utils;

namespace Teploset.Controllers
{
    public class ConcernController : Controller
    {
        public TeplosetUnitOfWork _repository;

        public ConcernController(TeplosetUnitOfWork repo)
        {
            _repository = repo;
        }

        // GET: Concern
        public ActionResult About(string id)
        {
            ViewBag.Lang = id;

            ViewBag.Title = id == "ua" ? "З Історії" : "Из истории";

            ViewBag.AboutCatalog = UtilsAbout.GetAbout(_repository, id);

            return View();
        }
    }
}