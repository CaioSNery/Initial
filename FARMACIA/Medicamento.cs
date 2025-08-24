using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.FARMACIA
{
    public class Medicamento
    {
        public decimal Preco { get; set; }
        public string NomeM { get; set; }
        public int Quantidade { get; set; }

        public Medicamento(decimal preco, string nomem, int quantidade)
        {
            Preco = preco;
            NomeM = nomem;
            Quantidade = quantidade;
        }
        public override string ToString()
        {
            return $"Nome - {NomeM},Preco - {Preco},Quantidade  -{Quantidade} Unid.s";
        }
    }
}