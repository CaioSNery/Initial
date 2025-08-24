using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.CURSO
{
    // Criando Variáveis para saldo(valor) e numero da conta(numero)
    public class ContaCorrente
    {
        private decimal saldo;
        public int numerodaConta;
        



        public ContaCorrente(int NumerodaConta, decimal Saldo)
        {
            saldo = Saldo;
            numerodaConta = NumerodaConta;
            

        }

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo = saldo - valor;
                Console.WriteLine("Saque Realizado");
            }
            else
            {
                Console.WriteLine("saldo insuficiente");
            }
        }

        public void ExibirSaldo(string nome)
        {
            Console.WriteLine($"Sr. {nome} Seu Saldo Atual e de " + saldo);

            

        }

        public void Depositar(decimal valort)
        {
            decimal saldot = valort + saldo;
            Console.WriteLine($"Transferencia recebida seu saldo atual e {saldot}");
            
            
        
            

        }


        }
        



    }

    

     



        // Instanciando 
        

        
        
        // Criar Metodo de sacar.

       
       
        
        
        //Criar Metodo exiberosaldo

        
    
