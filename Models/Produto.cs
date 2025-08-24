using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.Models
{
    public class Produto
    {
        public int Quantidade { get; set; }
        public string Nome { get; set; }

         public Produto(string nome,  int quanti)
        {
            Nome = nome;
            Quantidade = quanti;
            

        }
    }
}