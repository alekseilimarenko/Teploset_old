using System.Web.Mvc;
using Teploset.EF.Classes;
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
            

            ViewBag.Posts = UtilsPost.SelectLastPostsListForMainPage(_repository, Consts.CountPostForMainPage, id);
            ViewBag.Newses = UltisNews.SelectLastNewsListForMainPage(_repository, Consts.CountNewsForMainPage, id);
            ViewBag.Vacansies = UtilsVacancies.SelectVacanciesListForMainPage(_repository, Consts.CountVacanciesForMainPage, id);

            if (id == "ua")
            {
                ViewBag.Title = "Головна";
                return View("Index_ua");
            }

            ViewBag.Title = "Главная";
            return View("Index_ru");
        }

        public ActionResult About(string id)
        {
            if (id == "ua")
            {
                ViewBag.Title = "З Історії";
                return View("About_ua");
            }

            ViewBag.Title = "Из истории";
            return View("About_ru");
        }

        public ActionResult Contact(string id)
        {
            if (id == "ua")
            {
                ViewBag.Title = "Котакти";
                return View("Contact_ua");
            }

            ViewBag.Title = "Контакты";
            return View("Contact_ru");
        }
    }
}