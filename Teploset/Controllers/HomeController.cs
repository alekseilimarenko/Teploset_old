using System.Web.Mvc;
using Teploset.EF;
using Teploset.Utils;
using Consts = Teploset.Classes.Consts;
using Teploset.Models;

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

        public ViewResult VacancyList(string id)
        {
            ViewBag.Title = id == "ua" ? "Вакансії" : "Вакансии";
            ViewBag.Lang = id;

            var langId = id == "ua" ? EF.Classes.Consts.UaLang : EF.Classes.Consts.RuLang;

            VacancyListModel model = new VacancyListModel()
            {
                Vacancies = _repository
                .VacancyCatalog
                .Select(langId)
                .OrderByDefault()
            };

            return View(model);
    }

    public ActionResult Contact(string id)
        {
            ViewBag.Title = id == "ua" ? "Контакти" : "Контакты";
            return View("Contact");
        }
    }
}