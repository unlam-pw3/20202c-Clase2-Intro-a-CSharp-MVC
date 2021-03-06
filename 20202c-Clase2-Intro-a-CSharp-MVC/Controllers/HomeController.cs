﻿using _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios;
using _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios.EjercicioGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios = _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios;

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

            Random ran = new Random(DateTime.Now.Millisecond);
            int diaDeLaSemana = ran.Next(1, 8);
            string nombreDia = EjercicioEnumeraciones.ObtenerNombreDiaDeLaSemana((EjercicioEnumeraciones.DiasDeLaSemana)diaDeLaSemana);
            ViewBag.NombreDia = nombreDia;

            return View();
        }

        public ActionResult EjercicioOut()
        {
            //string textoOriginal = "Bella Y Bestia";
            //string textoInvertido = Ejercicios.EjercicioOut.InvertirTexto(textoOriginal);

            string textoOriginal = "Bella Y Bestia";
            string textoInvertido;
            Ejercicios.EjercicioOut.InvertirTexto(textoOriginal, out textoInvertido);

            ViewBag.TextoOriginal = textoOriginal;
            ViewBag.TextoInvertido = textoInvertido;

            return View();
        }

        public ActionResult EjercicioRef()
        {
            //string textoOriginal = "Bella Y Bestia";
            //string textoInvertido = Ejercicios.EjercicioOut.InvertirTexto(textoOriginal);

            string textoOriginal = "Bella Y Bestia";
            string textoFinal = textoOriginal;
            Ejercicios.EjercicioRef.TruncarTexto(ref textoFinal, 4);

            ViewBag.TextoOriginal = textoOriginal;
            ViewBag.TextoInvertido = textoFinal;

            return View();
        }


        public ActionResult EjercicioGenerics()
        {
            //string textoOriginal = "Bella Y Bestia";
            //string textoInvertido = Ejercicios.EjercicioOut.InvertirTexto(textoOriginal);

            EjemploGenerics<ISaludar> ejemploGenerics = new EjemploGenerics<ISaludar>();

            List<ISaludar> animalesQueSaludan = new List<ISaludar>();
            animalesQueSaludan.Add(new Perro() { Nombre = "Firulais" });
            animalesQueSaludan.Add(new Pez() { Nombre = "Nemo" });
            animalesQueSaludan.Add(new Grillo() { Nombre = "Pepe" });
            animalesQueSaludan.Add(new Cerdo() { Nombre = "Orson" } );

            string saludoGrupal = ejemploGenerics.SaludarTodos(animalesQueSaludan);

            ViewBag.SaludoGrupal = saludoGrupal;

            return View();
        }
    }
}