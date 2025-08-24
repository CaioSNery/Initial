using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.CadastroProduto
{
    public class Produto
    {
        public decimal Preco { get; set; }

        public string Nome { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, decimal preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;

        }
        
        // ToString 
         public override string ToString()
        {
            return $"Nome: {Nome}, Preço: R$ {Preco:F2}, Estoque: {Estoque} unidades";
        }
    }
}