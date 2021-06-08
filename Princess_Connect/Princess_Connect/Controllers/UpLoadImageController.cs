using Princess_Connect.Data.FrameWork;
using Princess_Connect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Princess_Connect.Controllers
{
    public class UpLoadImageController : Controller
    {
        // GET: UpLoadImage
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(CreateModels create)
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
            sQL_Character.Character_Picture = create.HinhAnhNhanVat;
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
    }
}