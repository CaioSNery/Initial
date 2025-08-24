using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.CURSO
{
    public class ClienteCc
    {
        public string Nome { get; set; }
        public int ContaBancaria { get; set; }
        




        public ClienteCc(string nome, int contabanco)
        {
            Nome = nome;
            ContaBancaria = contabanco;
            
        }

        public override string ToString()
        {
            return $"Nome {Nome} , Numero da conta {ContaBancaria}";
        }  
        

        
    }

    
}