using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea.Models;

namespace Tarea.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Formulario()
        {


            return View();
        }
      
        public ActionResult Resultado(Formulario form, HttpPostedFileBase foto, HttpPostedFileBase Curriculum)
        {
            if (Curriculum.ContentLength > 0)
            {
                var fileName = Path.GetFileName(Curriculum.FileName);
                var path = Path.Combine(Server.MapPath("~/Curriculum"), fileName);
                Curriculum.SaveAs(path);
                ViewBag.curriculum = fileName;
            }
            if (foto.ContentLength > 0)
            {
                var fileName = Path.GetFileName(foto.FileName);
                var path = Path.Combine(Server.MapPath("~/Imagen"), fileName);
                foto.SaveAs(path);
                ViewBag.foto = fileName;
            }
            return View(form);
        }

    }
}