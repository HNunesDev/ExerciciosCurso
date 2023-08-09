namespace SalarioImposto
{
    internal class Calculo
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            double valor = SalarioBruto - Imposto;
            return valor;
        } 
        public void AumentarSalario(double porcentagem)
        {
             SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem) / 100;           
        }


        public override string ToString()
        {
            return "Funcionário: " + Nome + ", $" + SalarioLiquido().ToString("F2");
        }
    }
}
