using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMO_DOC_GHI_FILE.Controllers
{
    public class UpLoadFileController : Controller
    {
        // GET: UpLoadFile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UpLoad()
        {
            var Image = Request.Files["Image"];
            var document = Request.Files["Document"];
            var path =Server.MapPath("~/UploadFiles/");
            if(Image != null && Image.ContentLength>0)
            {
                Image.SaveAs(path + Image.FileName);
                ViewBag.FileNameImage = Image.FileName;
            }
            if(document != null && document.ContentLength>0)
            {
                document.SaveAs(path + document.FileName);
                ViewBag.FileName = document.FileName;
                ViewBag.FileSize = document.ContentLength;
                ViewBag.FileStyle = document.ContentType;
            }
            return View();
        }
    }
}