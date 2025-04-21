using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CURSO_POO_NELIO_ALVES
{
    class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public double CalcularArea()
        {
            double p = ((LadoA + LadoB + LadoC) / 2);
            double areaTriangulo = Math.Sqrt((p * (p - LadoA) * (p - LadoB) * (p - LadoC)));
            return areaTriangulo;
        }     
    }
}
