using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace initial.SoftwareFila
{
    public class ClientIdoso
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public ClientIdoso(int idade1, string nome1)
        {
            Idade = idade1;
            Nome = nome1;
        }
       
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}