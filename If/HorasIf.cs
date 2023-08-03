Console.WriteLine("Que horas sao?");
int horas = int.Parse(Console.ReadLine());

if (horas < 12)
{
    Console.WriteLine("Bom dia!")
}
else if (horas < 18){
    Console.WriteLine("Boa tarde!")
}
else
{
    Console.WriteLine("Boa noite!")
}