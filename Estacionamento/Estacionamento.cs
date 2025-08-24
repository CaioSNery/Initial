using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using initial.Estacionamento;

namespace initial.Estacionamento1;


class Estacionamento
{
    // criamos as propriedados privadas da classe . e sua string
    private decimal PrecoInicial;
    private decimal precoPorHora;
    private List<Veiculos> veiculos;
    private List<Clientes> clientes;


    // CONSTRUTOR COM PARAMETROS , REFERENCIA THIS
    public Estacionamento(decimal PrecoInicial, decimal precoPorHora)
    {
        this.PrecoInicial = PrecoInicial;
        this.precoPorHora = precoPorHora;
        veiculos = new List<Veiculos>();
        clientes = new List<Clientes>();
    }
    public void AdicionarCLiente()
    {
        Console.WriteLine("Para cadastrar digite o nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o CPF");
        string cpf = Console.ReadLine();

        Clientes clientenovo = new Clientes(cpf, nome);
       
        clientes.Add(clientenovo);
        Console.WriteLine("Cliente Nome{0} CPF {1} Adicionado ", clientenovo.Nome, clientenovo.Cpf);
    }

    //adiconamos o veiculos
    public void AdicionarVeiculo()
    {
        Console.WriteLine("...Digite a Placa do Veiculo...");
        string placa = Console.ReadLine();
        Console.WriteLine("... Digite o Modelo do veiculo");
        string modelo = Console.ReadLine();
        Veiculos veiculosex = new Veiculos(modelo, placa);
        
        veiculos.Add(veiculosex);

        Console.WriteLine(" == Veiculo modelo: {0} com placa : {1} adicionado == ", veiculosex.Modelo, veiculosex.Placa);
    }


    // remove o veiculo
    public void RemoverVeiculo()
    {
        Console.WriteLine("Possui Cadastro ? 's/n'");
        string res3 = Console.ReadLine();
        if (res3 == "s" || res3 == "S")
        {
            Console.WriteLine("Digite o CPF cadastrado");
            string cpf = Console.ReadLine();

            Clientes client;
            client = clientes.Find(c => c.Cpf.Equals(cpf, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Cliente encontrado{0} , {1}", client.Nome, client.Cpf);


        }
        else if (res3 != "s" || res3 != "S")

        {
            Console.WriteLine("Deseja fazer cadastro? s'n ");
            string res4 = Console.ReadLine();
            if (res4 == "s" || res4 == "S")
            {
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite seu CPF");
                string cpf = Console.ReadLine();

                Clientes client = new Clientes(cpf, nome)
                {
                    Cpf = cpf,
                    Nome = nome
                };
                clientes.Add(client);
            }
            else
            {
                Console.WriteLine("Voltando ao menu principal");
                return;
            }

        }


        Console.WriteLine("...Digite a Placa do veiculos...");
        string placa = Console.ReadLine();

        Veiculos veic;
        veic = veiculos.Find(r => r.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));


        if (veiculos.Contains(veic))

        {
            Console.WriteLine("Digite o tempo em que o veiculo permanceu estacionado");
            int horas = int.Parse(Console.ReadLine());

            decimal valorTotal = PrecoInicial + (precoPorHora * horas);
            Console.WriteLine($"O valor total da placa{placa} foi de {valorTotal:F2}, Modelo {veic.Modelo}");
            Console.WriteLine("Confirmar ? s/n");
            Console.Write("Digite : ");
            string res2 = Console.ReadLine();
            if (res2 == "s" || res2 == "S")
            {

                Console.WriteLine($"`{veic.Modelo} e {veic.Placa} Removido com suceso");
                veiculos.Remove(veic);

            }


        }
        else
        {
            Console.WriteLine("ERROR --PLACA NAO ENCONTRADA , DIGITE NOVAMENTE...");
        }
    }
    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)

        {
            Console.WriteLine("...Os Veiculos estacionados sao : ...");

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"--{veiculo}--");
            }
        }
        else
        {
            Console.WriteLine("== Não há Veiculos estacionados");
        }

    }
    public void ListarClientes()
    {
        if (clientes.Count > 0)
        {
            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Nao ha Clientes cadastrados ");
        }
    }
}
    
    


   


    
















//{
//     private decimal precoInicial;
//     private decimal precoPorHora;
//     private List<string> veiculos;

//     public Estacionamento(decimal precoInicial, decimal precoPorHora)
//     {
//         this.precoInicial = precoInicial;
//         this.precoPorHora = precoPorHora;
//         veiculos = new List<string>();
//     }

//     public void AdicionarVeiculo()
//        {
//           Console.Write("Digite a placa do veículo para estacionar: ");
//           string placa = Console.ReadLine();
//           veiculos.Add(placa);
//           Console.WriteLine("Veículo adicionado com sucesso!");
//        }

//       public void RemoverVeiculo()
//     {
//            Console.Write("Digite a placa do veículo para remover: ");
//             string placa = Console.ReadLine();

//             if (veiculos.Contains(placa))
//            {
//               Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
//               int horas = int.Parse(Console.ReadLine());

//               decimal valorTotal = precoInicial + (precoPorHora * horas);
//               veiculos.Remove(placa);

//                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R${valorTotal:F2}");
//            }
//             else
//            {
//                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira a placa digitada.");
//            }
//        }
//     public void ListarVeiculos()
//     {
//         if (veiculos.Count > 0)
//         {
//             Console.WriteLine("Os veículos estacionados são:");
//             foreach (var veiculo in veiculos)
//             {
//                 Console.WriteLine($"- {veiculo}");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Não há veículos estacionados.");
//         }
//     }
// }







 