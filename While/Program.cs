Console.WriteLine("Entre com o código do combustivel");
int combustivel = int.Parse(Console.ReadLine());
int alcool = 0;
int gasolina = 0;
int dissel = 0;

while (combustivel != 4)
{
    if (combustivel == 1)
    {
        alcool = alcool + 1;
    }
    else if (combustivel == 2)
    {
        gasolina = gasolina + 1;
    }
    else if (combustivel == 3)
    {
        dissel = dissel + 1;
    }

    combustivel = int.Parse(Console.ReadLine());
}

Console.WriteLine("Alcool: " + alcool);
Console.WriteLine("Gasolina: " + gasolina);
Console.WriteLine("Dissel: " + dissel);