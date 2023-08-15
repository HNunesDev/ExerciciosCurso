using System.Reflection.Metadata.Ecma335;

namespace Estoque
{
    internal class Sistema
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Sistema(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return Nome; }
            set { if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int valor)
        {
            Quantidade = Quantidade + valor;
        }

        public void RemoverProduto(int valor)
        {
            Quantidade = Quantidade - valor;
        }

        public override string ToString()
        {
            return _nome + ", $" + Preco + ", " + Quantidade + " unidades, Valor total $ " + ValorEmEstoque().ToString("F2");
        }
   
    }
}
