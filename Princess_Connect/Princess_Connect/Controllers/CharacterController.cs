using Princess_Connect.Data.FrameWork;
using Princess_Connect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Princess_Connect.Controllers
{
    public class CharacterController : Controller
    {
        private Model dao = null;

        public CharacterController()
        {
            dao = new Model();
        }
        // GET: Header
        [HttpGet]
        public ActionResult Header()
        {
            if(Session["Name"] == null)
            {
                ViewBag.name = "Đăng nhập/Đăng ký";
            }
            else
            {
                ViewBag.name = Session["Name"].ToString();
            }
            return View();
        }

        // GET: Character
        [HttpGet]
        public ActionResult TrangChu()
        {
            List<Characters> list = new data().getAll();
            //ViewBag.list = list;
            return View(list);
        }

        //[HttpGet]
        //public ActionResult ChiTiet(string NV)
        //{
        //    SQL_Story sQL_Story = new DataModel().getDetail(NV);
        //    return View(sQL_Story);
        //}

        //[HttpGet]
        //public ActionResult ThemNhanVat()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult DangNhap()
        //{
        //    Session["Name"] = "Nguyễn Phát Thành Tài";
        //    return Redirect("TrangChu");
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult ThemNhanVat(CreateModels create)
        //{
        //    //Tạo mã nhân vật
        //    DateTime time = DateTime.Now;
        //    string day = DateTime.Now.ToString("dd");
        //    string Min = DateTime.Now.ToString("mm");
        //    string sec = DateTime.Now.ToString("ss");

        //    string MaNhanVat = "NV" + day + "" + Min + "" + sec;

        //    //lấy dữ liệu từ front-end
        //    string TenNhanVat = create.TenNhanVat;
        //    string CotTruyen = create.CotTruyen;
        //    string AnhCotTruyen = create.AnhCotTruyen;

        //    //lấy ảnh đã chọn từ front-end
        //    string fileName = System.IO.Path.GetFileNameWithoutExtension(create.ImageFile.FileName);
        //    //string extension = System.IO.Path.GetExtension(create.ImageFile.FileName);
        //    fileName = fileName + ".jpg";
        //    string pathSave = "~/Image/" + fileName;
        //    fileName = System.IO.Path.Combine(Server.MapPath("~/Image/"), MaNhanVat + ".jpg");
        //    create.ImageFile.SaveAs(fileName);

        //    SQL_Character sQL_Character = new SQL_Character();
        //    sQL_Character.Character_Id = MaNhanVat;
        //    sQL_Character.Character_Name = TenNhanVat;
        //    sQL_Character.Character_Picture = MaNhanVat + ".jpg";
        //    SQL_Story sQL_Story = new SQL_Story();
        //    sQL_Story.Character_Id = MaNhanVat;
        //    sQL_Story.Story_Id = MaNhanVat;
        //    sQL_Story.Character_Story = CotTruyen;
        //    sQL_Story.Character_Picture_Story = AnhCotTruyen;

        //    if (new DataModel().Create(sQL_Character, sQL_Story))
        //    {
        //        return RedirectToAction("TrangChu", "Character");
        //    }
        //    ModelState.AddModelError("", "Có lỗi xảy ra rồi");
        //    return View(create);
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

    }
}