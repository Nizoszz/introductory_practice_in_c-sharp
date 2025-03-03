using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        double firstNumber = ReadDoubleInput("Digite seu primeiro numero double: ");
        double secondNumber = ReadDoubleInput("Digite seu segundo numero double: ");
        double sum = firstNumber + secondNumber;

        Console.WriteLine($"O total da soma é: {sum}");
    }

    static double ReadDoubleInput(string prompt)
    {
        double value;
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? string.Empty;

            if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
            {
                return value;
            }

            Console.WriteLine("Por favor, insira um valor double corretamente.");
        }
    }
}