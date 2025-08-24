using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.SoftwareFila
{
    public class ClienteFila
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public ClienteFila(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}