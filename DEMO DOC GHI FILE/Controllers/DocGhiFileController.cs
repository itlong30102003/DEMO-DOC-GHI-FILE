using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace DEMO_DOC_GHI_FILE.Controllers
{
    public class DocGhiFileController : Controller
    {
        // GET: DocGhiFile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(string MaSV, string HoTenSV, double? DiemSo)
        {
            try {
                var path = Server.MapPath("~/Data.text");
                string[] lines = { MaSV, HoTenSV, DiemSo.ToString() };
                System.IO.File.WriteAllLines(path, lines);
                ViewBag.KetQua = "Ghi thanh cong";
            }
            catch(Exception ex) {
                ViewBag.KetQua = "Ghi that bai";
            }
            return View("Index");
        }  
        public ActionResult Open()
        {
            try {
                var path = Server.MapPath("~/Data.text");
                string[] lines = System.IO.File.ReadAllLines(path);
                ViewBag.MaSV = lines[0];
                ViewBag.HoTenSV = lines[1];
                ViewBag.DiemSo = lines[2];
                ViewBag.KetQua = "Doc thanh cong";
            }
            catch(Exception ex) {
                ViewBag.KetQua = "Doc that bai";
            }
            return View("Index");
        }
    }
}