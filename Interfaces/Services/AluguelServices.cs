using System;
using System.Collections.Generic;
using System.Text;
using SemInterface.Entidades;

namespace SemInterface.Services
{
    class AluguelServices
    {
        public double PrecoPorHora { get; set; }
        public double PrecoPorDia { get; set; }

        //Declarar um objeto do tipo BrasilTaxaServices e instanciá-lo (Dependência). Não é ainda
        //a melhor solução, pois uma melhor abordagem seria criar uma Interface. Temos
        //que evitar o forte acoplamento.
        private BrasilTaxaServices _brasilTaxaService = new BrasilTaxaServices();

        public AluguelServices(double precoPorHora, double precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        public void ProcessoFatura(AluguelVeiculo aluguelVeiculo)
        {
            TimeSpan duracao = aluguelVeiculo.Fim.Subtract(aluguelVeiculo.Inicio);
            double pagamentoBasico = 0.0;

            //Valida a duração da locação do veículo e arredonda para cima
            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            //Calcula o imposto baseado no pagamento básico
            double taxa = _brasilTaxaService.Taxa(pagamentoBasico);

            //Instanciar a fatura
            aluguelVeiculo.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}
