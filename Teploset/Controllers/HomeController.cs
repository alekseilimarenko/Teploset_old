using System.Web.Mvc;
using Teploset.EF.Interfaces;

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
    }
}