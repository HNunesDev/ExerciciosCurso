Console.WriteLine("Quantas alturas iremos ler? ");
int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine());
}

double soma = 0.0;
for (int i = 0;i < n; i++)
{
    soma += vect[i];
}
double media = soma / n;
Console.WriteLine("A média das alturas informadas é: " +  media.ToString("F2"));