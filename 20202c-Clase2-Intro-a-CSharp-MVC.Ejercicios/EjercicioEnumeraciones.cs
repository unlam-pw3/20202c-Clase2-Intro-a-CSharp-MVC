using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios
{
    //public enum EnumeracionSinClase
    //{
    //    //[Description("Todos los dias")]
    //    TodosLosDias = 0,
    //    Domingo = 1,
    //    Lunes = 2,
    //    Martes = 3,
    //    Miercoles = 4,
    //    Jueves = 5,
    //    Viernes = 6,
    //    Sabado = 7
    //}
    public class EjercicioEnumeraciones
    {
        public enum DiasDeLaSemana
        {
            TodosLosDias = 0,
            Domingo = 1,
            Lunes = 2,
            Martes = 3,
            Miercoles = 4,
            Jueves = 5,
            Viernes = 6,
            Sabado = 7
        }

        public static string ObtenerNombreDiaDeLaSemana(DiasDeLaSemana diaDeLaSemana)
        {
            switch (diaDeLaSemana)
            {
                case DiasDeLaSemana.TodosLosDias:
                    return "Todos los dias";
                case DiasDeLaSemana.Domingo:
                    return "Domingo";
                case DiasDeLaSemana.Lunes:
                    return "Lunes";
                case DiasDeLaSemana.Martes:
                    return "Martes";
                case DiasDeLaSemana.Miercoles:
                    return "Miercoles";
                case DiasDeLaSemana.Jueves:
                    return "Jueves";
                case DiasDeLaSemana.Viernes:
                    return "Viernes";
                case DiasDeLaSemana.Sabado:
                    return "Sabado";
            }

            return "";
        }
    }
}
