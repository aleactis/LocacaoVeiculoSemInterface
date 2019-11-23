using System;
using System.Globalization;
using SemInterface.Entidades;
using SemInterface.Services;
using static System.Console;

namespace SemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Digite os dados do aluguel");
            ForegroundColor = ConsoleColor.Red;
            Write("Modelo do carro: ");
            string modelo = ReadLine();
            ResetColor();
            Write("Retirada do veículo: (dd/MM/yyyy hh:mm): ");
            ForegroundColor = ConsoleColor.Red;
            DateTime retirada = DateTime.Parse(ReadLine());
            ResetColor();
            Write("Entrega do veículo: (dd/MM/yyyy hh:mm): ");
            ForegroundColor = ConsoleColor.Red;
            DateTime entrega = DateTime.Parse(ReadLine());
            ResetColor();
            Write("Digite o preço por hora: ");
            ForegroundColor = ConsoleColor.Red;
            double precoPorHora = double.Parse(ReadLine(),CultureInfo.InvariantCulture);
            ResetColor();
            Write("Digite o preço por dia: ");
            ForegroundColor = ConsoleColor.Red;
            double precoPorDia = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            //Instanciar um aluguel de veículo
            AluguelVeiculo aluguelVeiculo = new AluguelVeiculo(retirada,entrega,new Veiculo(modelo));
            //Instanciar um serviço de aluguel
            AluguelServices aluguelServices = new AluguelServices(precoPorHora, precoPorDia);
            //Associar o objeto Fatura ao aluguel do veículo
            aluguelServices.ProcessoFatura(aluguelVeiculo);

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine();
            WriteLine("::::::::::: FATURA :::::::::::");
            WriteLine(aluguelVeiculo.Fatura);
            ResetColor();
        }
    }
}
