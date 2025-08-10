using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    namespace Actividad1
    {
        public class Cubo
        {
            private Cuadrado cara;

            public Cubo(double lado)
            {
                cara = new Cuadrado(lado);
            }

            public double CalcularArea()
            {
                return cara.CalcularArea() * 6;
            }

            public double CalcularVolumen()
            {
                return cara.CalcularArea() * cara.Largo;
            }

            public string Describir()
            {
                string json = $@"{{
                ""Figura"": ""Cubo"",
                ""Lado"": {cara.Largo},
                ""Área"": {this.CalcularArea()},
                ""Volumen"": {this.CalcularVolumen()}
            }}";
                return json;
            }
        }
    }
}


