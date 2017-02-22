using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using Teploset.EF;
using Teploset.EF.Classes;
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
        public ActionResult Index(string id, int page = 1)
        {
            ViewBag.Title = id == "ua" ? "Концерн&laquo;МТМ&raquo; | Об'яви" : "Концерн&laquo;ГТС&raquo; | Объявления";
            ViewBag.Lang = id;

            var langId = id == "ua" ? Consts.UaLang : Consts.RuLang;
             
            var listPosts = _repository
                        .PostCatalog
                        .Select(langId)
                        .OrderByDefault()
                        .Skip((page - 1) * Classes.Consts.pageSize)
                        .Take(Classes.Consts.pageSize)
                        .ToList(); 

            return View(listPosts);
        }

        //POST
        public ActionResult Details(Guid postId, string langType)
        {
            ViewBag.Title = langType == "ua" ? "Концерн&laquo;МТМ&raquo; | Об'яви" : "Концерн&laquo;ГТС&raquo; | Объявления";
            ViewBag.Lang = langType;

            var post = _repository.PostCatalog.GetById(postId);

            return View(post);
        }
    }
}