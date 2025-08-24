using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using initial.BIBLIOTECA;

namespace initial.Models
{
    public class TesteBiblioteca
    {
        private List<Clientes> listaclientes = new List<Clientes>();



        public void ListarBio()
        {
            Console.WriteLine("Biografia");
            Console.WriteLine("1 - Hello");
            Console.WriteLine("escolha abaixo");

            string biografia = Console.ReadLine();

            if (!int.TryParse(biografia, out int escolha))
            {
                Console.WriteLine("Nao foi possivel localizar");
                return;
            }
            string caminho = escolha switch
            {
                1 => "Models/hello.txt",
                _ => null
            };
            if (caminho == null)
            {
                Console.WriteLine("Opção invalida");
                return;

            }
            if (!File.Exists(caminho))
            {
                Console.WriteLine("Biografia nao encontrada");
            }
            Console.WriteLine($"a biografia escola foi{Path.GetFileName(caminho)}");
            string[] linhas = File.ReadAllLines(caminho);
            foreach (string linha in linhas)
            {
                Console.Write(linha);
            }
        }


        public void ListarLivro()
        {
            Console.WriteLine("Escolha seu livro");
            Console.WriteLine("1 . alo");
            Console.WriteLine("Escolha baixo");

            string escolha2 = Console.ReadLine();
            if (!int.TryParse(escolha2, out int escolha3))
            {
                Console.WriteLine("Nao foi possivel localizar");
                return;
            }
            string caminho1 = escolha3 switch
            {
                1 => "Models/alo.txt",
                _ => null
            };
            if (caminho1 == null)
            {
                Console.WriteLine("Opcao invalida");
                return;
            }
            if (!File.Exists(caminho1))
            {
                Console.WriteLine("Livro nao encontrado");
                return;
            }

            Console.WriteLine($"Livro {Path.GetFileName(caminho1)}");
            string[] linha1 = File.ReadAllLines(caminho1);
            foreach (string linha2 in linha1)
            {
                Console.WriteLine(linha2);
                
            }  
        }
           




        }
    }



