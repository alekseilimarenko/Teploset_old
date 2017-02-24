using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using Teploset.EF;
using Teploset.EF.Classes;
using Teploset.Models;
using Teploset.Utils;

namespace Teploset.Controllers
{
    public class PostController : Controller
    {
        private readonly TeplosetUnitOfWork _repository;

        protected readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public PostController(TeplosetUnitOfWork repo)
        {
            _repository = repo;
        }
        // GET : Post
        public ViewResult Index(string id, int page = 1)
        {
            ViewBag.Title = id == "ua" ? "Об'яви" : "Объявления";
            ViewBag.Lang = id;

            var langId = id == "ua" ? Consts.UaLang : Consts.RuLang;

            PostsListViewModel model = new PostsListViewModel()
            {
                Posts = _repository
                    .PostCatalog
                    .Select(langId)
                    .OrderByDefault()
                    .Skip((page - 1)*3)
                    .Take(3),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = Classes.Consts.pageSize,
                    TotalItems = _repository.PostCatalog.Select(langId).Count()
                }
            };

            return View(model);
        }

        //POST
        public ActionResult Details(Guid postId, string langType)
        {
            ViewBag.Title = langType == "ua" ? "Об'яви" : "Объявления";
            ViewBag.Lang = langType;

            var post = _repository.PostCatalog.GetById(postId);

            return View(post);
        }
    }
}