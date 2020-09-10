using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios.EjercicioGenerics
{
    public class Grillo : ISaludar
    {
        public string Nombre { get; set; }

        public string Saludar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CRI CRI ");
            sb.Append(Nombre);

            return sb.ToString();
        }
    }
}
