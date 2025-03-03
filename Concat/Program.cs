using System;

class Program
{
    static void Main()
    {
        string firstName = "";
        string lastName = "";
        while (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
        {
            Console.WriteLine("Digite seu primeiro nome: ");
            firstName = Console.ReadLine() ?? string.Empty; ;
            Console.WriteLine("Digite seu sobrenome: ");
            lastName = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Os nomes não podem estar em branco.");
            }
        }
        Console.WriteLine(string.Format("Olá, {0} {1}!", firstName, lastName));
    }
}