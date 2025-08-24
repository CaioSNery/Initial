using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.SoftwareFila
{
    public class Fila
    {
        public Queue<ClienteFila> clientes = new Queue<ClienteFila>();
        public Queue<ClientIdoso> clientesI = new Queue<ClientIdoso>();




        public void AdicionarFilaNormal()
        {
            Console.WriteLine("Digite o nome :");
            string nome = Console.ReadLine();


            Console.WriteLine("Idade :");
            int idade = int.Parse(Console.ReadLine());

            ClienteFila clients = new ClienteFila(nome, idade);
           
            clientes.Enqueue(clients);


        }



        public void AdicionarClientePriori()
        {
            Console.WriteLine("Digite o nome :");
            string nome1 = Console.ReadLine();


            Console.WriteLine("Idade :");
            int idade1 = int.Parse(Console.ReadLine());

            ClientIdoso novopriori = new ClientIdoso(idade1, nome1);
            
            clientesI.Enqueue(novopriori);
            
        }

        public void Mostrarfila()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nao ha ninguem na fila-NORMAL");
                return;
            }
            if (clientes.Count != 0)
            {
                foreach (var lista in clientes)
                {
                    Console.WriteLine($"Fila Normal {lista}");
                }
            }
            if (clientesI.Count == 0)
            {
                Console.WriteLine("Não ha ninguem na fila - PRIORIDADE");
                return;

            }
            if (clientesI.Count != 0)
            {
                foreach (var item in clientesI)
                {
                    Console.WriteLine($"Fila Prioridade : {item}");
                }

            }

        }

        public void Atendimento()
        {
            if (clientesI.Count == 0)
            {
                var cliente1 = clientes.Dequeue();
                Console.WriteLine($"{cliente1} sendo atendido!");

            }
            
            if (clientesI.Count != 0)
            {
                var client2 = clientesI.Dequeue();
                Console.WriteLine($"{client2} Sendo Atendimento");

            }

            
            
        }

    }
}