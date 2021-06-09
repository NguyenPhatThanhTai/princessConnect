using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Princess_Connect.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Trangchu()
        {
            return View();
        }

        public ActionResult ThemNhanVat()
        {
            return View();
        }
    }
}