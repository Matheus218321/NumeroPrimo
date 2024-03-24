while (true)
{
    int Numero = 0;
    Console.Write("Digite um número inteiro: ");
    Numero = Convert.ToInt32(Console.ReadLine());

    if(VerificarNumeroPrimo(Numero) == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("O número " + Numero + " é primo!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("O número " + Numero + " não é primo");
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.WriteLine();
}

bool VerificarNumeroPrimo(int Numero)
{
    if(Numero == 2)
    {
        return true;
    }

    if(Numero == 1)
    {
        return false;
    }

    for(int i = 2; i < Numero; i++)
    {
        if(Numero % i == 0)
        {
            return false;
        }
    }

    return true;
}