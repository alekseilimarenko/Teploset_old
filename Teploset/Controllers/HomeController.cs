using System.Web.Mvc;
using Teploset.Classes;
using Teploset.EF.Interfaces;
using Teploset.Utils;

namespace Teploset.Controllers
{
    public class HomeController : Controller
    {
        private ITeplosetRepository _repository;

        protected readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public HomeController(ITeplosetRepository repo)
        {
            _repository = repo;
        }

        // GET: Home
        public ActionResult Index(string id)
        {
            ViewBag.Lang = id;

            ViewBag.Posts = UtilsPost.SelectLastPostsListForMainPage(_repository, Consts.CountPostForMainPage, id);
            ViewBag.Newses = UltisNews.SelectLastNewsListForMainPage(_repository, Consts.CountPostForMainPage, id);
            ViewBag.Vacansies = _repository.Vacancies;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}