using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios.EjercicioGenerics
{
    public class EjemploGenerics<T> where T : ISaludar
    {
        public static List<char> ObtenerLetras(string texto)
        {
            return texto.ToCharArray().ToList();
        }

        public string SaludarTodos(List<T> seresVivos)
        {
            string vitacoraDeRespiraciones = "";

            foreach (var serVivo in seresVivos)
            {
                vitacoraDeRespiraciones += Environment.NewLine + serVivo.Saludar();
            }

            return vitacoraDeRespiraciones;
        }
    }
   
}
