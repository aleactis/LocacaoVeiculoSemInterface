using System;
using System.Collections.Generic;
using System.Text;

namespace SemInterface.Entidades
{
    public class Veiculo
    {
        public string Model { get; set; }

        public Veiculo(string model)
        {
            Model = model;
        }
    }
}
