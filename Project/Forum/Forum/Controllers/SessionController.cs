using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class SessionController : Controller
    {
        public ActionResult LogIn()
        {
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Register()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}