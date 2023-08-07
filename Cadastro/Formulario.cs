using OrientadoObjeto;

ClasseFormulario Primeira = new ClasseFormulario();
ClasseFormulario Segunda = new ClasseFormulario();

Console.Write("Entre com o nome da pessoa que quer cadastrar: ");
Primeira.Name = Console.ReadLine();
Console.Write("Entre agora com a idade: ");
Primeira.Age = int.Parse(Console.ReadLine());


Console.Write("Entre com o nome da segunda pessoa que quer cadastrar: ");
Segunda.Name = Console.ReadLine();
Console.Write("Entre agora com a idade: ");
Segunda.Age = int.Parse(Console.ReadLine());


if (Primeira.Age > Segunda.Age)
{
    Console.WriteLine("A pessoa mais velha é a: " + Primeira.Name);
}
else
{
    Console.WriteLine("A pessoa mais velha é a: " +  Segunda.Name);
}