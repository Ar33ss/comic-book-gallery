using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_practica_tech.Controllers 
{
    public class EstudiantesController : Controller
    {
        public ActionResult Detalle() {
            ViewBag.Ups = "s";

            return View();
        }
    }
}