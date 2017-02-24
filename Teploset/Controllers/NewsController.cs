using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teploset.EF;
using Teploset.EF.Classes;
using Teploset.Models;

namespace Teploset.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        private readonly TeplosetUnitOfWork _repository;

        protected readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public NewsController(TeplosetUnitOfWork repo)
        {
            _repository = repo;
        }
        // GET : Post
        public ViewResult Index(string id, int page = 1)
        {
            ViewBag.Title = id == "ua" ? "Новини" : "Новости";
            ViewBag.Lang = id;

            var langId = id == "ua" ? Consts.UaLang : Consts.RuLang;

            NewsListViewModel model = new NewsListViewModel()
            {
                Newses = _repository
                    .NewsCatalog
                    .Select(langId)
                    .OrderByDefault()
                    .Skip((page - 1) * 3)
                    .Take(3),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = Classes.Consts.pageSize,
                    TotalItems = _repository.NewsCatalog.Select(langId).Count()
                }
            };

            return View(model);
        }

        //POST
        public ActionResult Details(Guid postId, string langType)
        {
            ViewBag.Title = langType == "ua" ? "Новини" : "Новости";
            ViewBag.Lang = langType;

            var post = _repository.NewsCatalog.GetById(postId);

            return View(post);
        }
    }
}