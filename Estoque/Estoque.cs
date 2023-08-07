
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

Console.WriteLine("Dados atualizados: " + sistema);

Console.Write("Quantos produtos chegaram?");
int novaQuantidade =  int.Parse(Console.ReadLine());
sistema.AdicionarProduto(novaQuantidade);

Console.WriteLine("Dados do produto: " + sistema);

Console.Write("Quantos produtos sairam?");
int quantidadeFinal = int.Parse(Console.ReadLine());
sistema.RemoverProduto(quantidadeFinal);

Console.WriteLine("Dados atualizados: " + sistema);
