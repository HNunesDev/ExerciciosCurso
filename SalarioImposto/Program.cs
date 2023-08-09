using SalarioImposto;

Calculo conta = new Calculo();
Console.WriteLine("Entre com os dados do funcionário: ");
Console.Write("Nome: ");
conta.Nome = Console.ReadLine();
Console.Write("Salário: ");
conta.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Imposto: ");
conta.Imposto = double.Parse(Console.ReadLine());
    
Console.WriteLine(" ");
Console.WriteLine(conta);

Console.Write("Digite a porcentagem para aumentar o salário: ");
double Numero = double.Parse(Console.ReadLine());
conta.AumentarSalario(Numero);

Console.WriteLine("Dados atualizados: " + conta);