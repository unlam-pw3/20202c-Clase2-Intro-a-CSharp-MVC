using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios.EjercicioGenerics
{
    public class Perro : ISaludar
    {
        public string Nombre { get; set; }

        public string Saludar()
        {
            return string.Format("GUAU GUAU {0}", Nombre);
        }
    }
}
