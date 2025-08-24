using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using initial.BIBLIOTECA;

namespace initial.FARMACIA
{
    public class FARMACIA1
    {
        public List<Cliente> clientes = new List<Cliente>();
        public List<Medicamento> remedios = new List<Medicamento>();



        public void CadastrarCliente()
        {
            Console.WriteLine("~~Por Favor Digite o nome do Cliente  : ");
            Console.WriteLine("ou aperta 'v' para voltar");
            Console.Write("\n Digite : ");
            string nome = Console.ReadLine();

            if (nome == "v" || nome == "V")
            {
                Console.WriteLine("Retornando ao menu principal.");
                return;
            }

            Console.WriteLine(" ~~ Digite o C P F ~~");
                string cpf = Console.ReadLine();

                Console.WriteLine($"Cliente {nome} - CPF {cpf} ## CONFIRMAR CADASTRO ? \n Digite s / n ");
                string resp = Console.ReadLine();

                if (resp == "S" || resp == "s")
                {
                    Cliente novoCliente = new Cliente(nome, cpf);
                    clientes.Add(novoCliente);
                    Console.WriteLine("Cadastro Nome - {0} , CPF - {1}  Realizado com Sucesso !", novoCliente.Nome, novoCliente.Cpf);

                }
                else
                {
                    Console.WriteLine("Operação CANCELADA");
                }
           

        }

        public void CadastrarMedicamento()
        {
            Console.WriteLine("~~ Digite o nome do Medicamento . ~~");
            Console.WriteLine("ou aperte 'v' para voltar ao menu principal");
            Console.Write("\n Digite : ");

            string nome = Console.ReadLine();


            if (nome == "v" || nome == "V")
            {
                Console.WriteLine("Retornando ao menu principal.");
                return;
            }

            Console.WriteLine("~~ Cadastre o Preço ~~");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("~~ Informe a Quantidade em Estoque ~~");
            int quantidade = int.Parse(Console.ReadLine());

            Medicamento remedio = new Medicamento(preco, nome, quantidade);
            remedios.Add(remedio);

            Console.WriteLine($"Medicamento Armazenado {nome} - R${preco:F2} - {quantidade} Unidades.");

        }



        public void Venda()
        {
            Console.WriteLine("~~Digite o CPF do cliente: ");
            Console.Write(" ou Aperte 'v' para cancelar a venda.");
            Console.Write("\n Digite :");

          string cpf = Console.ReadLine();
            if (cpf == "v" || cpf == "V")
            {
                Console.WriteLine("Voltando ao Menu Principal.");
                return;
          }

            Cliente clienteExistente = clientes.Find(c => c.Cpf == cpf);
            if (clienteExistente == null)
            {
                Console.WriteLine("Cliente nao cadastrado \n deseja cadastrar S/N ?");
                string resp = Console.ReadLine();


                if (resp == "S" || resp == "s")
                {
                    Console.WriteLine("Digite o Nome :");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o CPF :");
                    string cpfNovo = Console.ReadLine();

                    clienteExistente = new Cliente(nome, cpfNovo);
                    clientes.Add(clienteExistente);

                }
                else
                {
                    Console.WriteLine("Prosseguir com a venda : ");

                }
            }
            else if (clienteExistente != null)
            {
                Console.WriteLine("Cliente : {0}", clienteExistente);
                
            }
            Console.WriteLine("Aperte 's' para continuar ou 'n' parar voltar ao menu.");
            string resp1 = Console.ReadLine();
            if (resp1 == "s" || resp1 == "S")
            {
                Console.WriteLine(" ...... ");
            }
            else
            {
                return;
            }

            Medicamento remedio; // Do While  - Loop ate haver uma verdade.
            do
            {
                Console.WriteLine("~~Informe o Medicamento ~~");
                string nomeMedicamento = Console.ReadLine();

                 remedio = remedios.Find(r => r.NomeM.Equals(nomeMedicamento, StringComparison.OrdinalIgnoreCase));

                if (remedio == null)
                {
                    Console.WriteLine("Remedio nao encontrado.");

                }
            } while (remedio == null);



            int quantidade; // Do While
            do
            {
                Console.WriteLine("~~Quantidade ~~");
                string input = Console.ReadLine();

                //try parse usado com ! por que se o numero digitado for invalido
                // ele da false, e o ! transforma em verdadeiro
                // com o operador OR - se uma das duas expressões for verdadeiras
                // o if passa.

                if (!int.TryParse(input, out quantidade) || quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida");
                }
                else
                {
                    break;
                }
            } while (true);
            
    
            //Se for cliente desconto 10%
                if (remedio.Quantidade >= quantidade && clienteExistente != null)
                {


                    
                    decimal precoComdesconto = remedio.Preco * 0.9M;                
                    decimal precototal = precoComdesconto * quantidade;
                Console.WriteLine("Valor Total da Venda com Desconto : {0}, Deseja Prosseguir? 's/n' ", precototal);
                string res = Console.ReadLine();
                if (res == "s" || res == "S")
                {
                    Console.WriteLine($"Venda realizada com sucesso!");
                    Console.WriteLine($"Desconto aplicado: 10%");
                    Console.WriteLine($"Preço unitário com desconto: {precoComdesconto:C}");
                    Console.WriteLine($"Total: {precototal:C}");
                    remedio.Quantidade -= quantidade;
                }
                  
                    if (remedio.Quantidade == 0)
                {
                    remedios.Remove(remedio);
                    Console.WriteLine("Produto esgotado e removido");
                }
                }
                else if (remedio.Quantidade >= quantidade)
                {
                    
                    decimal novoPreco = remedio.Preco * quantidade;
                Console.WriteLine("Compra no valor {0:F2}, Confirmar compra ? 's/n'", novoPreco);
                string res = Console.ReadLine();
                if (res == "s" || res == "S")
                {
                     remedio.Quantidade -= quantidade;
                    Console.WriteLine(" Venda Realizada {0} - {1} Unidades - Preco Total R${2:F}", remedio.NomeM, quantidade, novoPreco);
                }

                }
                else
                {
                    Console.WriteLine("Quantidade excede Estoque");
                }
        }

        public void ListarClientes()
        {
            if (clientes != null && clientes.Any())
            {
                foreach (var item in clientes)
                {
                    Console.WriteLine($"Nome - {item.Nome} CPF - {item.Cpf}");

                }
            }
            else
            {
                Console.WriteLine("Nao há clientes cadastrados.");
            }
        }

        public void ListarMedicamento()
        {
            

            if (remedios != null && remedios.Any())
            {
                foreach (var item in remedios)
                {
                    Console.WriteLine($"Remedio: {item.NomeM} - Valor R${item.Preco:F2} - Estoque {item.Quantidade}");
                }
            }
            else
            {
                Console.WriteLine("Nao há Medicamentos cadastrados.");
            }

        }

        public void EditarCliente()
        {
            Console.WriteLine("~~ Digite o nome do cliente ~~");
            Console.WriteLine("ou aperte 'V' para voltar ao Menu principal");
            Console.Write("\n Digite : ");
            string resp3 = Console.ReadLine();

            if (resp3 == "v" || resp3 == "V")
            {
                Console.WriteLine("Voltando ao Menu Principal");
                return;
            }

            Cliente clienteex = clientes.Find(c => c.Nome.Equals(resp3, StringComparison.OrdinalIgnoreCase));

            if (clienteex != null)
            {
                Console.WriteLine("CLiente encontrado \n Digite o novo nome: ");
                string novoNome = Console.ReadLine();

                Console.WriteLine(" Digite o CPF");
                string novoCPF = Console.ReadLine();

                clienteex.Nome = novoNome;
                clienteex.Cpf = novoCPF;

                Console.WriteLine("Mudança Realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente nao encontrado !");
            }

        }

        public void EditarMedicamento()
        {
            Console.WriteLine("Digite o nome do medicamento : ");
            Console.WriteLine("ou aperta 'v' para voltar ao menu principal");
            Console.Write("\n Digite : ");
            string resp4 = Console.ReadLine();

            Medicamento remedioex = remedios.Find(t => t.NomeM.Equals(resp4, StringComparison.OrdinalIgnoreCase));

            if (remedioex != null)
            {
                Console.WriteLine("Medicamento encontrado \n Digite Nome :");
                string novoNome1 = Console.ReadLine();
                Console.WriteLine("Informe a nova quantidade : ");
                int novaquanti = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Preco : ");
                decimal novoPreco = decimal.Parse(Console.ReadLine());

                remedioex.NomeM = novoNome1;
                remedioex.Quantidade = novaquanti;
                remedioex.Preco = novoPreco;

                Console.WriteLine("Produto Editado com sucesso !");

            }
            else
            {
                Console.WriteLine("Medicamento nao encontrado !");
            }
        }

        public void RemoverCliente()
        {
            Console.WriteLine("Digite o nome cadastrado");
            Console.WriteLine("ou aperta 'v' para voltar ao menu principal");
            Console.Write("\n Digite : ");
            string resp5 = Console.ReadLine();
            Cliente removecli = clientes.Find(c => c.Nome.Equals(resp5, StringComparison.OrdinalIgnoreCase));
            if (removecli != null)
            {
                clientes.Remove(removecli);
                Console.WriteLine($"Cliente {removecli.Nome} removido com sucesso");
            }
            else
            {
                Console.WriteLine("Cliente nao encontrado");
            }


        }

        public void RemoverProduto()
        {
            Console.WriteLine("Informe o nome do Medicamento");
            Console.WriteLine("ou aperta 'v' para voltar ao menu principal");
            Console.Write("\n Digite : ");
            string resp6 = Console.ReadLine();

            Medicamento removem = remedios.Find(r => r.NomeM.Equals(resp6, StringComparison.OrdinalIgnoreCase));
            if (removem != null)
            {
                Console.WriteLine("Deseja deletar o Medicamento : {0} ? 's/n'", removem);
                string resp = Console.ReadLine();
                if (resp == "s" || resp == "S")
                {
                    remedios.Remove(removem);
                    Console.WriteLine($"{removem} retirado do estoque ");
                }
                else
                {
                    Console.WriteLine(" ..... ");
                    return;
                }
                
            }
            else
            {
                Console.WriteLine("Medicamento nao encontrado");
            }
        }
    

    }


}