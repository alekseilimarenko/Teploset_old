using System.Web.Mvc;
using Teploset.EF;
using Teploset.Utils;
using Consts = Teploset.Classes.Consts;

namespace Teploset.Controllers
{
    public class HomeController : Controller
    {
        private readonly TeplosetUnitOfWork _repository;

        protected readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public HomeController(TeplosetUnitOfWork repo)
        {
            _repository = repo;
        }

        // GET: Home
        public ActionResult Index(string id)
        {
            ViewBag.Lang = id;
            

            ViewBag.Posts = UtilsPost.SelectPostsList(_repository, Consts.CountPostForMainPage, id);
            ViewBag.Newses = UltisNews.SelectLastNewsListForMainPage(_repository, Consts.CountNewsForMainPage, id);
            ViewBag.Vacansies = UtilsVacancies.SelectVacanciesListForMainPage(_repository, Consts.CountVacanciesForMainPage, id);

            ViewBag.Title = id == "ua" ? "Головна" : "Главная";
            
            return View("Index");
        }

        public ActionResult About(string id)
        {
            ViewBag.Title = id == "ua" ? "З Історії": "Из истории";

            return View("About");
        }

        public ActionResult Contact(string id)
        {
            ViewBag.Title = id == "ua" ? "Контакти" : "Контакты";
            return View("Contact");
        }
    }
}