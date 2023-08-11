using Aluno;
using System.Net.Http.Headers;

Notas AlunoUm = new Notas();

Console.WriteLine("Entre com o nome do aluno e as três notas dele: ");
Console.Write("Nome: ");
AlunoUm.Nome = Console.ReadLine();
Console.Write("Primeira nota: ");
AlunoUm.NotaUm = double.Parse(Console.ReadLine());
Console.Write("Segunda Nota: ");
AlunoUm.NotaDois = double.Parse(Console.ReadLine());
Console.Write("Terceira Nota: ");
AlunoUm.NotaTres = double.Parse(Console.ReadLine());


Console.WriteLine(AlunoUm);

double midia = AlunoUm.Media();
if (midia < 60.00)
{
    Console.WriteLine("Reporvado");
    double faltante = midia - 60.00;
    Console.WriteLine("Faltaram: " +  faltante + "pontos");
}
else
{
    Console.WriteLine("Aprovado");
}