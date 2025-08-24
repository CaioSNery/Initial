using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.Perfumaria
{
    public class Produto
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public Produto(decimal valor, string nome, int quantidade)
        {
            Valor = valor;
            Nome = nome;
            Quantidade = quantidade;

        }

        public override string ToString()
        {
            return $"PRECO {Valor} PRODUTO {Nome} QUANTIDADE{Quantidade}";
        }

    }
    
}