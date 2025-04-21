using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOS_DE_FIXACAO_SOBRE_CLASSES
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura; 
        }    

        public double CalcularArea()
        {
            double area = Largura * Altura;
            return area;
        }
        public double CalcularPerimetro()
        {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }
        public double CalcularDiagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }

        public override string ToString()
        {
            string infoRetangulo = $"\nDADOS DO RETANGULO \nÁrea: {CalcularArea():F2}, \nPerímetro: {CalcularPerimetro():F2}, \nDiagonal: {CalcularDiagonal():F2}";
            return infoRetangulo;
        }

    }
}
