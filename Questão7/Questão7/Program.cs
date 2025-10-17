int x = 0;
int numeroinicial, numerofinal = 0;
Console.WriteLine("Digite o número final:");
numerofinal = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número inicial:");
numeroinicial = int.Parse(Console.ReadLine());
while (true)
{
    if (numeroinicial > numerofinal)
    {
        //finaliza
        return
        ;
    }
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{numeroinicial}x{i}={numeroinicial * i}");

    }
    numeroinicial++;
}




