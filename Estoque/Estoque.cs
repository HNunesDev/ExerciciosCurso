// See https://aka.ms/new-console-template for more information
using Estoque;
Sistema sistema = new Sistema();

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
sistema.Nome = Console.ReadLine();
Console.Write("Preço: ");
sistema.Preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
sistema.Quantidade = int.Parse(Console.ReadLine());
double estoque = sistema.ValorEmEstoque();

Console.WriteLine("Dados do produto: " + sistema);

