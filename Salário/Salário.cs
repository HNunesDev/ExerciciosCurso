using Salário;

ClasseSalario P1 = new ClasseSalario();
ClasseSalario P2 = new ClasseSalario();

Console.WriteLine("Entre com os dados dos funcionários: ");
Console.Write("Nome: ");
P1.Nome = Console.ReadLine();
Console.Write("Salário: ");
P1.Salario = double.Parse(Console.ReadLine());

Console.Write("Nome: ");
P2.Nome = Console.ReadLine();
Console.Write("Salário: ");
P2.Salario = double.Parse(Console.ReadLine());

double media = (P1.Salario +  P2.Salario) / 2;

Console.WriteLine("O salário médio dos funcionários é de: " +  media.ToString("F2"));