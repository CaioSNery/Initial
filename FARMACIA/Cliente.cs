using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.FARMACIA
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;

        }

        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {Cpf}";
        }
    }
}