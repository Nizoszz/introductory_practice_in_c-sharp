using System;

class Program
{
    static void Main()
    {
        String name = "";
        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Digite seu nome: ");
            name = Console.ReadLine() ?? "";
        }
        Console.WriteLine("Olá, " + name + "! Seja bem-vindo!");
    }
}