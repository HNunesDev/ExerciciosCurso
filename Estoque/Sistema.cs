using System.Reflection.Metadata.Ecma335;

namespace Estoque
{
    internal class Sistema
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Sistema(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return Nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get { return _preco; }
        }
        public double Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int valor)
        {
            _quantidade = _quantidade + valor;
        }

        public void RemoverProduto(int valor)
        {
            _quantidade = _quantidade - valor;
        }

        public override string ToString()
        {
            return _nome + ", $" + _preco + ", " + _quantidade + " unidades, Valor total $ " + ValorEmEstoque().ToString("F2");
        }
   
    }
}
