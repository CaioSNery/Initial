using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.Estacionamento
{
    public class Veiculos
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public Veiculos(string modelo, string placa)
        {
            Modelo = modelo;
            Placa = placa;
        }

        public override string ToString()
        {
            return $"Modelo {Modelo} , Placa {Placa}";
        }
        

    }
}