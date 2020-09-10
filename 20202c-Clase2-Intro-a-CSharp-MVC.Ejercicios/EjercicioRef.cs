using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios
{
    public class EjercicioRef
    {
        public static void TruncarTexto(ref string texto, int cantidad)
        {
            texto = texto.Substring(0, cantidad);
        }
    }
}
