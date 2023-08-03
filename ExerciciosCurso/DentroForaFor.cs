Console.Write("Quantos números inteiros serao lidos? ");
int x = int.Parse(Console.ReadLine());

int dentro = 0;
int fora = 0;
for (int i = 1; i <= x; i++)
{
    Console.WriteLine("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    if (numero >= 10 && numero <= 20)
    {
        dentro = dentro + 1;
    }
    else
    {
        fora = fora + 1;
    }
}
Console.WriteLine("Números dentro do intervalo: " + dentro);
Console.WriteLine("Números fora do intervalo: " + fora);
