using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha um formato para exibir a data/hora atual:");
            Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
            Console.WriteLine("2 - Apenas a data (dd/MM/yyyy)");
            Console.WriteLine("3 - Apenas a hora (HH:mm:ss)");
            Console.WriteLine("4 - Data com o mês por extenso");
            Console.WriteLine("5 - Sair");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine() ?? string.Empty;

            DateTime agora = DateTime.Now;

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Data completa: {agora.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR"))}");
                    break;

                case "2":
                    Console.WriteLine($"Apenas a data: {agora.ToString("dd/MM/yyyy")}");
                    break;

                case "3":
                    Console.WriteLine($"Apenas a hora: {agora.ToString("HH:mm:ss")}");
                    break;

                case "4":
                    Console.WriteLine($"Data com mês por extenso: {agora.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"))}");
                    break;

                case "5":
                    Console.WriteLine("Programa encerrado.");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
