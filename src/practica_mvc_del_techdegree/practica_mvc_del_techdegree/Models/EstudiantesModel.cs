using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica_mvc_del_techdegree.Models
{
    public class EstudiantesModel
    {
        public string Titulo {get; set;}
        public string Descripcion { get; set; }
        public string[] Peliculas { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }

        public int suma {
            get {
                return N1 + N2;
            }
        }

    }
}