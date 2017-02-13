using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teploset.EF.Interfaces;

namespace Teploset.Controllers
{
    public class UaController : HomeController
    {
        private ITeplosetRepository repository;
        public UaController(ITeplosetRepository repo) : base(repo)
        {
            repository = repo;
        }
        
        // GET: Ua
        public ActionResult Index_ua()
        {
            ViewBag.Posts = repository.Posts;
            ViewBag.Newses = repository.Newses;
            ViewBag.Vacansies = repository.

            return View();
        }

        
    }
}