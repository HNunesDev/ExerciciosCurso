using Vetor;

Console.WriteLine("Quantas produtos iremos ter? ");
int n = int.Parse(Console.ReadLine());

Product[] vect = new Product[n];
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());
    vect[i] = new Product { Name = name, Valor = price };
}
double soma = 0.0;
for (int i = 0;i < n; i++)
{
    soma += vect[i].Valor;
}
double media = soma / n;
Console.WriteLine("A media dos preços é: " + media.ToString("F2"));