namespace ContaBancária
{
    internal class Sistema
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Sistema(int conta, string nome)
        {
            Numero = conta;
            Titular = nome;
        }
        public override string ToString()
        {
            return "Conta: " + Numero + ", titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2");
        }
        public Sistema(int conta, string nome, double deposito) : this(conta, nome) {
            AdicionarSaldo(deposito);
        }

        public void AdicionarSaldo(double saldoAdicional)
        {
            Saldo = Saldo + saldoAdicional;
   
        }
        public void SaqueSaldo(double saque)
        {
            Saldo = (Saldo - saque) - 5;
        }

    }
} 
