using System;
using static System.Console;

namespace SemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Digite os dados do aluguel".ToUpper());
            ForegroundColor = ConsoleColor.White;
            Write("Modelo do carro: ".ToUpper());
            ForegroundColor = ConsoleColor.Red;
            string model = ReadLine().ToUpper();
            ResetColor();
            Write("Retirada: (dd/MM/yyyy hh:mm): ");
            DateTime retirada = DateTime.Parse(ReadLine());

        }

        void MudaCor(string cor)
        {
        }
    }
}
