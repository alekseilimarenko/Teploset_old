using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teploset.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClearCache()
        {
            CcAppRoot.Instance.AppCacheManager.ClearCache();
            SessionCache.ClearCache();
            return View("Index");
        }
    }
}