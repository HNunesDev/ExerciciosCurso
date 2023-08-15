using ContaBancária;

Sistema sistemaBancario;

Console.WriteLine("Entre com as informações da conta: ");
Console.Write("Número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Titular da conta: ");
string nome = Console.ReadLine();
Console.Write("Haverá depósito inicial? (s/n) ");
char resposta = char.Parse(Console.ReadLine());
if (resposta == 's')
{
    Console.Write("Valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine());
    sistemaBancario = new Sistema(numero, nome, depositoInicial);
}
else
{
    sistemaBancario = new Sistema(numero, nome);
}

Console.WriteLine(sistemaBancario);

Console.WriteLine("Entre com um valor para deposito: ");
double deposito =  double.Parse(Console.ReadLine());
sistemaBancario.AdicionarSaldo(deposito);

Console.WriteLine(sistemaBancario);

Console.WriteLine("Entre com um valor para saque: ");
double saque = double.Parse(Console.ReadLine());
sistemaBancario.SaqueSaldo(saque);

Console.WriteLine(sistemaBancario);

