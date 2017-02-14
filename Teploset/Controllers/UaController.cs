using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teploset.Classes;
using Teploset.EF.Interfaces;
using Teploset.Utils;

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
            ViewBag.Posts = UtilsPost.SelectLastPostsListForMainPage(repository, Consts.CountPostForMainPage);
            ViewBag.Newses = UltisNews.SelectLastNewsListForMainPage(repository, Consts.CountPostForMainPage);
            ViewBag.Vacansies = repository.Vacancies;

            return View();
        }

        
    }
}