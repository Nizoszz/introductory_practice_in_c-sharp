using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite a placa do carro (ou digite 'quit' para encerrar): ");
            string pattern = @"^[a-zA-Z]{3}-[0-9]{4}$";
            string input = Console.ReadLine() ?? string.Empty;
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }
            if (!Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Por favor, insira uma placa válida (formato: ABC-1234)!");
                continue;
            }
            Console.WriteLine($"Placa válida: {input}");
            break;
        }
    }
}