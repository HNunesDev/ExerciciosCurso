namespace ConversorDeMoeda
{
    internal class Cambio
    {
        public static double Dolar;
        public static double Quantidade;
        public static double Troca(double dolar, double quantidade)
        {
            double valor = dolar * quantidade;
            double valorFinal = (valor * 6 / 100) + valor;
            return valorFinal;
        }

        
    }
}
