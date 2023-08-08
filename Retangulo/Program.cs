// See https://aka.ms/new-console-template for more information
using Retangulo;

Retanguloo X = new Retanguloo();


Console.WriteLine("Entre com a altura e largura do Retangulo: ");
Console.Write("Largura: ");
X.Largura = double.Parse(Console.ReadLine());
Console.Write("Altura: ");
X.Altura = double.Parse(Console.ReadLine());

double areaX = X.Area();
double perimetroX = X.Perimetro();
double diagonalX = X.Diagonal();

Console.WriteLine(X);