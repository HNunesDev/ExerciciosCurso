using System.IO;

namespace Retangulo
{
    public class Retanguloo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            double a = Largura * Altura;
            return a;
        }
        public double Perimetro()
        {
            double p = (Largura *2) + (Altura * 2);
            return p;
        }
        public double Diagonal()
        {
            double d = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return d;
        }

        public override string ToString()
        {
            return "A Area do retangulo é: " + Area().ToString("F2") + " Seu perimetro: " + Perimetro().ToString("F2") + " E por fim sua diagnonal: " + Diagonal().ToString("F2");
        }
    }
}
