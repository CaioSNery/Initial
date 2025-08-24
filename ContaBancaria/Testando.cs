using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.Models
{
    public class Testando
    {
        private decimal saldo;
        public int numeroConta;


        public Testando(decimal Saldo, int NumeroConta)
        {
            saldo = Saldo;
            numeroConta = NumeroConta;
        }

        public void Sacar(decimal valor)
        {
            saldo = saldo - valor;
            if (valor <= saldo)
            {
                Console.WriteLine("Saque efetuado com sucesso");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

            public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo atual e de" + saldo);
        }
            
            
        }
    }
