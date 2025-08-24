using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace initial.Perfumaria
{
    public class Loja
    {
        public List<Clientes> clientes = new List<Clientes>();
        public List<Produto> produtos = new List<Produto>();
        public List<Produto> produtosPer = new List<Produto>();
        public Queue<Clientes> filaN = new Queue<Clientes>();


        public void Adccliente()
        {
            Console.WriteLine("Para Adicionar Digite o nome");
            Console.Write("\n Digite : ");
            string nome = Console.ReadLine();

            Console.WriteLine("Para Adicionar Digite o CPF");
            Console.Write("\n Digite : ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Cadastrar {0} - Cpf {1} ? Confirmar 's/n'", nome,cpf);

            string resp = Console.ReadLine();
            if (resp == "s" || resp == "S")
            {  
                  Clientes novoCliente = new Clientes(nome, cpf);
                clientes.Add(novoCliente);
                Console.WriteLine("ADICIONADO COM SUCESSO");
                
            }
            else
            {
                Console.WriteLine("... Voltando ao menu principal...");
                return;
            }

        }

        public void AdcProdutos()
        {

            Console.WriteLine("1 - PERFUMES");
            Console.WriteLine("2 - CREMES");
            Console.Write("\n OPÇÃO :");

            int resp1 = int.Parse(Console.ReadLine());

            if (resp1 == 1)
            {
                Console.WriteLine("Digite Perfume");
                string nome = Console.ReadLine();

                Console.WriteLine("Valor");
                decimal valor = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite quantidade");
                int quantidade = int.Parse(Console.ReadLine());

                Produto novoProduto = new Produto(valor, nome, quantidade);

                Console.WriteLine("Cadastrar {0} - Cpf {1} ? Confirmar 's/n'", novoProduto.Nome, novoProduto.Nome);

                string resp = Console.ReadLine();
                if (resp == "s" || resp == "S")
                {
                    Console.WriteLine("ADICIONADO COM SUCESSO");
                    produtosPer.Add(novoProduto);
                }
                else
                {
                    Console.WriteLine("... Voltando ao menu principal...");
                    return;
                }
            }

            if (resp1 == 2)
            {
                Console.WriteLine("Digite Creme");
                string nome = Console.ReadLine();

                Console.WriteLine("Valor");
                decimal valor = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite Perfume");
                int quantidade = int.Parse(Console.ReadLine());

                Produto novoProduto = new Produto(valor, nome, quantidade);

                Console.WriteLine("Cadastrar {0} - Cpf {1} ? Confirmar 's/n'", novoProduto.Nome, novoProduto.Nome);

                string resp = Console.ReadLine();
                if (resp == "s" || resp == "S")
                {
                    Console.WriteLine("ADICIONADO COM SUCESSO");
                    produtos.Add(novoProduto);
                }
                else
                {
                    Console.WriteLine("... Voltando ao menu principal...");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Opção Invalida");
                return;
            }

        }


        public void Vendas()
        {
            Console.WriteLine("Digite qual Produto");
            Console.WriteLine("1 - PERFUMES");
            Console.WriteLine("2 - CREMES");
            int resp = int.Parse(Console.ReadLine());

            if (resp == 1)
            {
                Console.WriteLine("... PERFUMES ...");
                foreach (var item in produtosPer)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Digite o nome do perfume :");
                string nome = Console.ReadLine();



                Produto perfume;


                do
                {
                    perfume = produtosPer.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

                    if (perfume == null)
                    {
                        Console.WriteLine("Perfume nao encontrado");
                    }
                } while (perfume == null);


                int quantidade;
                do
                {
                    Console.WriteLine("Digite a quantidade");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out quantidade) || quantidade <= 0)
                    {
                        Console.WriteLine("Quantidade inválida");


                    }
                    else
                    {
                        break;
                    }
                } while (true);

                if (perfume.Quantidade > quantidade)
                {

                    decimal valor = perfume.Valor * 0.9M;
                    decimal precofinal = valor * quantidade;
                    Console.WriteLine(precofinal);
                    perfume.Quantidade -= quantidade;

                }
                
                


            }

            if (resp == 2)
            {
                Console.WriteLine("... CREMES ...");
                foreach (var lista in produtos)
                {
                    Console.WriteLine(lista);
                }
                Console.WriteLine("Digite o nome do CREME :");
                string cremes = Console.ReadLine();

                Produto creme;
                do
                {
                    creme = produtosPer.Find(p => p.Nome.Equals(cremes, StringComparison.OrdinalIgnoreCase));

                    if (creme != null)
                    {
                        Console.WriteLine("Confirmar venda ? 's/n' ");
                        Console.Write("\n Digite:");
                        string sim = Console.ReadLine();

                        if (sim == "s" || sim == "S")
                        {
                            Console.WriteLine("Venda realizada!");
                            produtosPer.Remove(creme);
                        }

                    }
                    else
                    {
                        break;

                    }
                } while (creme == null);

                int quantidade;
                do
                {
                    Console.WriteLine("Digite a quantidade");
                    string input2 = Console.ReadLine();

                    if (!int.TryParse(input2, out quantidade) || quantidade >= 0)
                    {
                        Console.WriteLine("Quantidade invalida");
                    }
                     else
                    {
                        break;
                    }

                     } while (true);
                     

                    if (creme.Quantidade > quantidade)
                {
                    decimal valor = creme.Valor * 0.9M;
                    decimal precofinal = valor * quantidade;
                    Console.WriteLine(precofinal);
                    creme.Quantidade -= quantidade;
                }
                   

               


            }

        }
        public void Listar()
        {
            if (produtos != null || produtosPer != null)
            {
                foreach (var item in produtos)
                {
                    Console.WriteLine($"Cremes : {item}");
                }
                foreach (var item1 in produtosPer)
                {
                    Console.WriteLine($"Perfumes : {item1}");
                }
            }
            else
            {
                Console.WriteLine("LISTA VAZIA");
            }

        }

        public void AtendimentoFila()
        {
            Console.WriteLine("Digite Nome e dps cpf");
            Console.Write("\n Digite :");
            string nomefila = Console.ReadLine();
            Console.Write("\n Digite :");
            string cpf = Console.ReadLine();



            Clientes c = new Clientes(nomefila, cpf);

            filaN.Enqueue(c);

        }

        public void ChamarFila()
        {
            if (filaN.Count != 0)
            {
                var cliente1 = filaN.Dequeue();
                Console.WriteLine("Proximo Cliente a ser atendido -{0} CPF - {1}",cliente1.Nome,cliente1.Cpf);


            }
        }

        
        
    }

 }


