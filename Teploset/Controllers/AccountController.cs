using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Teploset.Models;

namespace Teploset.Controllers
{
    public class AccountController : Controller
    {
        //private IAuthenticationManager AuthenticationManager
        //{
        //    get
        //    {
        //        return HttpContext.GetOwinContext().Authentication;
        //    }
        //}

        [AllowAnonymous]
        [HttpGet]
        // GET: Account
        public ActionResult Login()
        {
            var model = new AuthorizationModel();
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(AuthorizationModel authModel)
        {
            if(String.IsNullOrEmpty(authModel.Login) || String.IsNullOrEmpty(authModel.Password))
            {
                if (String.IsNullOrEmpty(authModel.Login)) ModelState.AddModelError("Login", "Укажите логин");
                if (String.IsNullOrEmpty(authModel.Password)) ModelState.AddModelError("Password", "Укажите пароль");
            }
            return RedirectToAction("Index", "Admin");
        }


        public ActionResult LogOut()
        {
            Session.RemoveAll();
            Session.Clear();
            //AuthenticationManager.;

            return RedirectToAction("Index", "Home");

        }
    }
}