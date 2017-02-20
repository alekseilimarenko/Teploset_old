using System;
using System.Web.Mvc;
using Teploset.EF;

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
        public ActionResult Index(string id)
        {
            ViewBag.Title = "Концерн&laquo;МТМ&raquo; | Об'яви";
            ViewBag.Posts = Utils.UtilsPost.SelectPostsList(_repository, 0, id); 

            return View();
        }

        //POST
        public ActionResult Details(Guid id)
        {
            ViewBag.Title = "Концерн&laquo;МТМ&raquo; | Об'яви";

            return View();
        }
    }
}