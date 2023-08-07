using OrientadoObjeto;

Triangulo X = new Triangulo();
Triangulo Y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X:");
X.A = double.Parse(Console.ReadLine());
X.B = double.Parse(Console.ReadLine());
X.C = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do triângulo Y:");
Y.A = double.Parse(Console.ReadLine());
Y.B = double.Parse(Console.ReadLine());
Y.C = double.Parse(Console.ReadLine());

double areaX = X.Area();
double areaY = Y.Area();

Console.WriteLine("Área de X = " + areaX.ToString("F4"));
Console.WriteLine("Área de Y = " + areaY.ToString("F4"));
if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else
{
    Console.WriteLine("Maior área: Y");
}

