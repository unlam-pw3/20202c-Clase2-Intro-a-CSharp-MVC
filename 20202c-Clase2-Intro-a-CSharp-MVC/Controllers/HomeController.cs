using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20202c_Clase2_Intro_a_CSharp_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DiasDeLaSemana()
        {
            //Enunciado
            //1)Crear una enumeración con los días de la semana,
            //comenzando por Domingo con valor 
            //1.2)Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana

            return View();
        }
    }
}