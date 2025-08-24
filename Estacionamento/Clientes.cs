using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.Estacionamento
{
    public class Clientes
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }

        public Clientes(string cpf, string nome)
        {
            Cpf = cpf;
            Nome = nome;
        }
        public override string ToString()
        {
            return $"Nome { Nome} CPF {Cpf}";
        }
    }
}