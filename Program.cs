Console.WriteLine("----MÚLTIPLO----");
int n1, n2, resto;

Console.Write("digita um número legal aí:");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("digita um outro número legal aí:");
n2 = Convert.ToInt32(Console.ReadLine());

resto = n1 % n2;

if (resto == 0)
{
    Console.WriteLine($"{n1} é múltiplo de {n2}");
}
else
{
    Console.WriteLine($"{n1} não é múltiplo de {n2}");
}

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("\nmuito agradecido por me usar ¯\\_(XD)_/¯ viu!");
Console.ResetColor();