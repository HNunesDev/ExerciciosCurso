using System.Reflection.Metadata.Ecma335;

namespace Estoque
{
    internal class Sistema
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco + ", " + Quantidade  + " unidades, Valor total $ " + ValorEmEstoque().ToString("F2");
        }
    }
}
