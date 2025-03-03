using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite uma palavra e veja o numero da quantidade de letras existente na palavra: ");
            string word = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Por favor, insira uma palavra válida.");
                break;
            }
            if (word.ToLower() == "quit")
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }

            Console.WriteLine($"A palavra '{word}' tem {word.Length} letras.\n");
            Console.WriteLine("Caso deseja parar o programa digite: 'Quit'\n");

        }
    }
}