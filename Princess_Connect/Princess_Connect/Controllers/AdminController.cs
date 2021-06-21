using Princess_Connect.Data.FrameWork;
using Princess_Connect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Princess_Connect.Controllers
{
    public class AdminController : Controller
    {
        private DAO _DAO;

        public AdminController(DAO dao)
        {
            _DAO = dao;
        }
        // GET: Admin
        public ActionResult Trangchu()
        {
            List <Characters> list = _DAO.Characters.ToList();
            return View(list);
        }

        //public ActionResult ThemNhanVat()
        //{
        //    List<SQL_Story> list = new DataModel().getAll();
        //    ViewBag.list = list;
        //    return View();
        //}
    }
}