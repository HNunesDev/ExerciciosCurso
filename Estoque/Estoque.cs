
using Estoque;

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

Sistema system = new Sistema(nome, preco, quantidade);

double estoque = system.ValorEmEstoque();

Console.WriteLine("Dados atualizados: " + system);

Console.Write("Quantos produtos chegaram? ");
int novaQuantidade =  int.Parse(Console.ReadLine());
system.AdicionarProduto(novaQuantidade);

Console.WriteLine("Dados do produto: " + system);

Console.Write("Quantos produtos sairam?");
int quantidadeFinal = int.Parse(Console.ReadLine());
system.RemoverProduto(quantidadeFinal);

Console.WriteLine("Dados atualizados: " + system);
