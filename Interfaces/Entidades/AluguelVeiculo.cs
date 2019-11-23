using System;
using System.Collections.Generic;
using System.Text;
using SemInterface.Entidades;

namespace SemInterface.Entidades
{
    public class AluguelVeiculo
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelVeiculo(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
