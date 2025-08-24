using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.Perfumaria
{
    public class Clientes
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Clientes(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;

        }
        public override string ToString()
        {
            return $"{Nome}      -{Cpf}";
        }
    }
}