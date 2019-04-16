using practica_mvc_del_techdegree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practica_mvc_del_techdegree.Controllers
{
    public class EstudiantesController : Controller
    {
        public ActionResult Informacion() {

            EstudiantesModel b = new EstudiantesModel();

            b.Titulo = "Estudiantes con mejores notas";
            b.Descripcion = "Estos estdiantes se ganaron tickets para las siguientes peliculas : ";
            b.Peliculas = new string[]{
                "Amazing Spiderman",
                "Moana",
                "Harry Potter",
                "Avengers : EndGame",
                "Avengers: Infinity War"
            };

            b.N1 = 2;
            b.N2 = 5;

            return View(b);
        }

    }
}