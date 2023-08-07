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
double p = (X.A + X.B + X.C) / 2.0;
double areaX = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));
p = (Y.A + Y.B + Y.C) / 2.0;
double areaY = Math.Sqrt(p * (p - Y.A) * (p - Y.B) * (p - Y.C));
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

