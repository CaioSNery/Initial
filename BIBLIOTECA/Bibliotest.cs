using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.BIBLIOTECA
{
    public class Bibliotest
    {

        private List<Clientes> listaClientes = new List<Clientes>();



        public void Listar() // INDRODUÇÃO DO METODO LISTAR BIOGRAFIAS
        {
            // MENU COM OPTIONS.
            Console.WriteLine("\n=== Lista de Receitas Disponíveis ===");
            Console.WriteLine("\n=== Região Nordeste ===");
            Console.WriteLine("[1] - BAHIA (BA) ");
            Console.WriteLine("[2] - SERGIPE (SE) ");
            Console.WriteLine("[3] - ALAGOAS (AL) ");
            Console.WriteLine("[4] - PERNAMBUCO(PE)");
            Console.WriteLine("[5] - CEARA (CE) ");
            Console.WriteLine("[6] - PARAIBA (PB) ");
            Console.WriteLine("[7] - MARANHÃO (MA) ");
            Console.WriteLine("[8] - PIAUI (PI) ");
            Console.WriteLine("[9] - RIO GRANDE DO NORTE (RN) ");
            Console.Write("Digite a opção da receita desejada: ");
            Console.Write("\n Digite : ");

            string escolha1 = Console.ReadLine();
           
            if (!int.TryParse(escolha1, out int escolha))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.\n");
                return;
            }

            string caminho = escolha switch
            {
                1 => "BIBLIOTECA/BAHIA.txt",
                2 => "BIBLIOTECA/CEARA.txt",
                3 => "BIBLIOTECA/Hatshep.txt",
                4 => "BIBLIOTECA/RamsesII.txt",
                5 => "BIBLIOTECA/Tut.txt",
                _ => null
            };

            if (caminho == null)
            {
                Console.WriteLine("Opção inválida. Tente novamente.\n");
                return;
            }

            if (!File.Exists(caminho))
            {
                Console.WriteLine($"Arquivo não encontrado: {caminho}\n");
                return;
            }

            Console.WriteLine($"\n=== Conteúdo de {Path.GetFileName(caminho)} ===");
            string[] linhas = File.ReadAllLines(caminho);
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }
            Console.WriteLine();
        }

        public void ListarLivros()
        {
            Console.WriteLine("\n=== Lista de Livros Disponíveis ===");
            Console.WriteLine("1 - Os Segredos de Saqaara");
            Console.WriteLine("2 - A Primeira Faraó - Hatshepsut");
            Console.WriteLine("3 - Enigmas das areias.Vol II");
            Console.WriteLine("4 - Sobre as Piramides");
            Console.WriteLine("5 - A vida de Ramses II - The Great");
            Console.WriteLine("Digite o Número do Livro escolhido");

            string escolhaLivro = Console.ReadLine();

            //Tenta converter uma string para um número inteiro.
            //O primeiro é a string a ser convertida
            //O segundo é a variável de saída que vai receber o número convertido- 
            //                                   se a conversão for bem-sucedida.
            //Cria a variável escolha2 para armazenar o número convertido, se der certo.
            // (negação)
            //O ! inverte o resultado. Ou seja:
            //Se TryParse retornar false (ou seja, a conversão falhou), o if entra.
            //Isso significa que o usuário não digitou um número válido.
             if (!int.TryParse(escolhaLivro, out int escolha2))
            {
                Console.WriteLine("Entrada inválida , tente novamente \n");
                return;
            }

            // Cria a String Caminho1 atribui a escolha2
            //comeca o swtich

            string caminho1 = escolha2
            switch // No switch as Opcoes precisam da return;
            {
                1 => "BIBLIOTECA/Os Segredos de Saqaara.txt",
                2 => "BIBLIOTECA/A Primera Faraó - Hatsehsut.txt",
                3 => "BIBLIOTECA/Enigma das areais.Vol II.txt",
                4 => "BIBLIOTECA/Sobre as Piramides.txt",
                5 => "BIBLIOTECA/A vida de Ramses II - The Great.txt",
                _ => null

            };

            // Se caminho1 que e a escolha da pessoa nao estiver no switch.
            if (caminho1 == null)
            {
                Console.WriteLine("Opção Inválida , Tente novamente !");
                return; // return
            }
            //Olha se o arquivos nao existe
            if (!File.Exists(caminho1))
            {
                Console.WriteLine($"Opção Não encontrada{caminho1}\n");
                return; // return
            }

            //Path.GetFileName(caminho1) Extrai apenas o nome do arquivo (sem o caminho)
            //Exemplo Se caminho1 = "C:\\MeusArquivos\\Tutankhamon.txt"-
            //                      então Path.GetFileName(caminho1) retorna "Tutankhamon.txt"

            Console.WriteLine($"\n=== Conteúdo de {Path.GetFileName(caminho1)} ===");
            // File.ReadAllLines busca o texto
            string[] linhas = File.ReadAllLines(caminho1);
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine();

        }
        public void AdicionarCliente()
        {
            Console.WriteLine("Para fazer o cadastro informe os nomes abaixo : ");
            Console.WriteLine("Nome Completo");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("C-P-F");
            string cpfCliente = Console.ReadLine();

            Clientes clientes = new Clientes
            // Class Clientes cria clientes = novo Clientes
            // eu dou valor ao nome , com as variaveis string acima
            {
                Nome = nomeCliente,
                Cpf = cpfCliente,
            };

            listaClientes.Add(clientes);

            Console.WriteLine("\n Cliente cadastrado com sucesso");

        }
        public void ListarClientes()
        {
            if (listaClientes.Count == 0)
            {
                Console.WriteLine("\n Nenhum cliente encontrado!");
                return;
            }

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}, CPF: {cliente.Cpf}");
            }

        }

        public void RemoveCliente()
        {

            Console.WriteLine("Para encerrar o cadastro digite seu nome.");
            string remoNome = Console.ReadLine();

            Clientes clienteRemover = listaClientes.FirstOrDefault(c => c.Nome.Equals(remoNome, StringComparison.OrdinalIgnoreCase));
            if (clienteRemover != null)
            {
                Console.WriteLine($"Cliente encontrado: {clienteRemover.Nome} - CPF: {clienteRemover.Cpf}");
                Console.Write("Tem certeza que deseja remover este cliente? (S/N): ");
                string confirmacao = Console.ReadLine().Trim().ToUpper();

                if (confirmacao == "S")
             {
            listaClientes.Remove(clienteRemover);
            Console.WriteLine("Usuário removido com sucesso!");
             }
        else
        {
            Console.WriteLine("Remoção cancelada.");
        }
    }
    else
    {
        Console.WriteLine("Nome inválido. Cliente não encontrado.");
    }
   }
    
     }
 }





    
// using initial.BIBLIOTECA;

// Bibliotest es = new Bibliotest();


// while (true)
//             {
//                 Console.WriteLine(" ---<<() Bem Vindo a Biblioteca Virtual )>>---");
//                 Console.WriteLine("              ==== MENU ====");
//                 Console.WriteLine("           1 - Listar Biografias");
//                 Console.WriteLine("           2 - Listar Livros");
//                 Console.WriteLine("           3 - Fazer Cadastro");
//                 Console.WriteLine("           4 - Lista de Clientes");
//                 Console.WriteLine("           5 - Encerrar Cadastro");
//                 Console.WriteLine("           0 - Sair");
//                 Console.Write("           Escolha uma opção: ");

//                 string entrada = Console.ReadLine();


    
//         switch (entrada)
//         {
//             case "1":
//                 es.Listar();
//                 break;
//             case "2":
//                 es.ListarLivros();
//                 break;
//                 case"3":
//             es.AdicionarCliente();
//             break;
//             case"4":
//             es.ListarClientes();
//             break;
//             case"5":
//             es.RemoveCliente();
//             break;

//             case "0":
//                 Console.WriteLine("Encerrando o programa...");
//                 return;
//             default:
//                 Console.WriteLine("Opção inválida.");
//                 break;
//         }


        
//     }


        
    



   