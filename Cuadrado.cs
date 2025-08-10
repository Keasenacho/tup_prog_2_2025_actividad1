using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    public class Cuadrado
    {
        public double Ancho { get; set; }
        public double Largo { get; set;}

     public Cuadrado(double lado)
        {
            Largo=lado;
            Ancho=lado;
        }
        public double CalcularArea()
        {
            return Largo * Ancho;
        }
    }
}

















