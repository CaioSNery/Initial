using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.Models
{
    public class Mercado
    {
        public List<Produto> produtos = new List<Produto>();
        public int quantidade;
        public string nome;

        public void Cadastro()
        {
            Console.WriteLine("Qual a quantidade  de produto a serem cadastrados?");
            nome = Console.ReadLine();

            quantidade = int.Parse(Console.ReadLine());
           




        }
    }
}