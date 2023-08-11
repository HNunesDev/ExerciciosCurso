using ConversorDeMoeda;

Console.Write("Qual a cotação do dolar: ");
Cambio.Dolar = double.Parse(Console.ReadLine());
Console.Write("Quantos doláres ira comprar: ");
Cambio.Quantidade = double.Parse(Console.ReadLine());


Console.WriteLine("O valor a ser pago é de: $" + Cambio.Troca(Cambio.Dolar, Cambio.Quantidade).ToString("F2"));