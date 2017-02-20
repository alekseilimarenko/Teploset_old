using System.Web.Mvc;
using Teploset.EF;
using Teploset.Utils;
using Consts = Teploset.Classes.Consts;

namespace Teploset.Controllers
{
    public class HomeController : Controller
    {
        public TeplosetUnitOfWork _repository;

        public HomeController (TeplosetUnitOfWork repo)
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

        public ActionResult Contact(string id)
        {
            ViewBag.Title = id == "ua" ? "Контакти" : "Контакты";
            return View("Contact");
        }
    }
}