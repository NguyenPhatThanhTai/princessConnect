using Princess_Connect.Data.FrameWork;
using Princess_Connect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Princess_Connect.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<SQL_Story> list = new DataModel().getAll();
            ViewBag.list = list;
            return View(list);
        }

        [HttpGet]
        public ActionResult Detail()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateModels create)
        {
            //get image
            string fileName = System.IO.Path.GetFileNameWithoutExtension(create.ImageFile.FileName);
            string extension = System.IO.Path.GetExtension(create.ImageFile.FileName);
            fileName = fileName + extension;
            string pathSave = "~/Image/" + fileName;
            fileName = System.IO.Path.Combine(Server.MapPath("~/Image/"), fileName);
            create.ImageFile.SaveAs(fileName);

            SQL_Character sQL_Character = new SQL_Character();
            sQL_Character.Character_Id = create.MaNhanVat;
            sQL_Character.Character_Name = create.TenNhanVat;
            sQL_Character.Character_Picture = System.IO.Path.GetFileNameWithoutExtension(create.ImageFile.FileName);
            SQL_Story sQL_Story = new SQL_Story();
            sQL_Story.Character_Id = create.MaNhanVat;
            sQL_Story.Story_Id = create.MaNhanVat;
            sQL_Story.Character_Story = create.CotTruyen;
            sQL_Story.Character_Picture_Story = create.AnhCotTruyen;

            if (new DataModel().Create(sQL_Character, sQL_Story))
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Có lỗi xảy ra rồi");
            return View(create);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}