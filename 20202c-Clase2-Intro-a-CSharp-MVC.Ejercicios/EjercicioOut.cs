using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios
{
    public class EjercicioOut
    {
        public static string InvertirTexto(string texto)
        {
            char[] charArray = texto.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool InvertirTexto(string texto, out string resultado)
        {
            try
            {
                char[] charArray = texto.ToCharArray();
                Array.Reverse(charArray);
                resultado = new string(charArray);
                return true;
            }
            catch
            {
                resultado = null;
                return false;
            }
        }

    }

    public static class ExtensionesString
    {
        public static string Cortar(this string text, int cantidad)
        {
            //extension methods

            return text.Substring(0, cantidad);
        }

    }
}
