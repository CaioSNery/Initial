


namespace MeuProjeto
{

    public class Aula
    {
        decimal ValorInicial;
        decimal precoPorHora;
        public List<Veiculos> veiculos = new List<Veiculos>();

        public void AddVeiculo()
        {
            Console.WriteLine("Digite o Nome");
            Console.Write("\n Digite");
            string placa = Console.ReadLine();

            Console.WriteLine("Digite a Idade");
            Console.Write("\n DiGite: ");
            string marca = Console.ReadLine();

            Veiculos veicnovo = new Veiculos(placa, marca);
            veiculos.Add(veicnovo);

            Console.WriteLine("Cliente {0} - Idade {1} Adicionados", veicnovo.Placa, veicnovo.Marca);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa");
            string placa = Console.ReadLine();

            Veiculos veic;
            veic = veiculos.Find(r => r.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));

            if (veiculos.Contains(veic))
            {
                Console.WriteLine("Digite as horas");
                int horas = int.Parse(Console.ReadLine());
                decimal ValorInicial = 10M;
                decimal precoPorHora = 5M;

                decimal ValorTotal = ValorInicial + precoPorHora * horas;

                Console.WriteLine("Valor Total {0} Veiculos {1}", ValorTotal, veic.Placa);
                veiculos.Remove(veic);

            }
            else
            {
                Console.WriteLine("Placa nao Identificada!");
            }
        }

        public class Veiculos
        {
            public string Placa { get; set; }
            public string Marca { get; set; }

            public Veiculos(string placa, string marca)
            {
                Placa = placa;
                Marca = marca;
            }

            public override string ToString()
            {
                return $"Placa {Placa} - Marca {Marca}";
            }

          
        }

        class Program
        {
            static void Main()
            {

            
                Aula au = new Aula();

              
                string opcao;

                while (true)
                {
                    Console.WriteLine("1 Add");
                    Console.WriteLine("2 - Remove");

                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            au.AddVeiculo();
                            break;
                        case "2":
                            au.RemoverVeiculo();
                            break;
                        case "3":
                            return;
                    }
                }


            }
        }
    }
}






// using System;

//         const int tamanho = 3;

//         string[] nome = new string[tamanho];
//         string[] marca = new string[tamanho];
//         int[] dosagem = new int[tamanho];
//         decimal[] precovenda = new decimal[tamanho];
//         decimal[] precocompra = new decimal[tamanho];



// for (int i = 0; i < tamanho; i++)
// {
//     Console.WriteLine($"Cadastro Medicamento{i + 1}");

//     Console.Write("\n nome");
//     nome[i] = Console.ReadLine();

//     Console.Write("Marca");
//     marca[i] = Console.ReadLine();
//     Console.Write("Dosagem");

//     dosagem[i] = int.Parse(Console.ReadLine());
//     Console.WriteLine("Preco de Venda");
//     precovenda[i] = decimal.Parse(Console.ReadLine());

//     Console.WriteLine("Preco de COmpra");
//     precocompra[i] = decimal.Parse(Console.ReadLine());



// }

// for (int i = 0; i < tamanho; i++)
// {
//      Console.WriteLine($"Nome: {nome[i]}");
//             Console.WriteLine($"Marca: {marca[i]}");
//             Console.WriteLine($"Dosagem: {dosagem[i]} mg");
//             Console.WriteLine($"Preço Compra: R$ {precocompra[i]:F2}");
//             Console.WriteLine($"Preço Venda: R$ {precovenda[i]:F2}");
// } 








// // Exercício: Cadastro e Média de Notas de Turma
// // Descrição:
// // Crie um programa que:

// // Peça ao usuário quantos alunos ele quer cadastrar.

// // Para cada aluno, peça o nome e 3 notas.

// // Armazene essas informações (nome e notas).

// // Após o cadastro, calcule e mostre a média de cada aluno.

// // Exiba uma lista com o nome do aluno e a média calculada.

// using System;


//         Console.WriteLine("Quantos alunos deseja cadastrar?");
//         int quantidade = int.Parse(Console.ReadLine());

//         // Arrays para armazenar nomes e médias
//         string[] nomes = new string[quantidade];
//         double[,] notas = new double[quantidade, 3];  // 3 notas por aluno

//         // Cadastro de alunos e notas
//         for (int i = 0; i < quantidade; i++)
//         {
//             Console.WriteLine($"Digite o nome do aluno {i + 1}:");
//             nomes[i] = Console.ReadLine();

//             for (int j = 0; j < 3; j++)
//             {
//                 Console.WriteLine($"Digite a nota {j + 1} de {nomes[i]}:");
//                 // Ler e armazenar as notas
//                 notas[i, j] = double.Parse(Console.ReadLine());
//             }
//         }

//         // Calcular e mostrar as médias
//         for (int i = 0; i < quantidade; i++)
//         {
//             double media = CalcularMedia(notas, i);
//             Console.WriteLine($"Aluno: {nomes[i]} - Média: {media:F2}");
//         }


//     // Função para calcular a média das 3 notas de um aluno
//     static double CalcularMedia(double[,] notas, int indiceAluno)
//     {
//         double soma = 0;
//         for (int j = 0; j < 3; j++)
//         {
//             soma += notas[indiceAluno, j];
//         }
//         return soma / 3;
//     }



// using initial.HOSPEDAGEM;

// List<Clientes> hospedes = new List<Clientes>();

// Clientes p1 = new Clientes(nome: "Hóspede 1","45625365895");
// Clientes p2 = new Clientes(nome: "Hóspede 2", "06222446558");

// hospedes.Add(p1);
// hospedes.Add(p2);

// // Cria a suíte
// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 30);

// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 10);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");




// // TODO: Crie a Classe AnalisadorDeTransacoes:
// public class AnalisadorDeTransacoes
// {



//     public decimal Limite { get; set; }
//     private List<decimal> Transacoes = new List<decimal>();
//     // TODO: Crie a lista para armazenar as transações realizadas:


//     public AnalisadorDeTransacoes(decimal limite)
//     {
//         Limite = limite;
//         Transacoes = new List<decimal>();
//     }

//     public void AdicionarTransacao(decimal valor)
//     {
//         Transacoes.Add(valor);
//         // TODO: adicione a transação à lista Transacoes
//     }

//     public List<decimal> ObterTransacoesSuspeitas()
//     {
//         return Transacoes.Where(t => t > Limite).ToList();
//         // TODO: retorne as transações que são superiores ao limite
//     }

//     public void ExibirRelatorio()
//     {
//         var suspeitas = ObterTransacoesSuspeitas();
//         if (suspeitas.Count == 0)
//         {
//             Console.WriteLine("Nenhuma transação suspeita encontrada");
//         }

//         // TODO: Implemente a condição if para retornar uma mensagem informando que não há transações suspeitas:
//         else
//         {
//             decimal totalSuspeitas = suspeitas.Sum();
//             int numeroSuspeitas = suspeitas.Count();

//             string transacaoTexto = numeroSuspeitas == 1 ? "transacao suspeita" : "transacoes suspeitas";

//             Console.WriteLine("{0}: {1}", transacaoTexto, totalSuspeitas);
//             Console.WriteLine("{0}: {1 F2}", numeroSuspeitas,transacaoTexto);

//             // TODO: imprima o total das transações suspeitas com duas casas decimais
//             // e a quantidade de transações suspeitas

//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         decimal limite = decimal.Parse(Console.ReadLine());  
//         int quantidade = int.Parse(Console.ReadLine());

//         var analisador = new AnalisadorDeTransacoes(limite);

//         for (int i = 0; i < quantidade; i++)
//         {
//             decimal valor = decimal.Parse(Console.ReadLine());

//             analisador.AdicionarTransacao(valor);
//              // TODO: adicione a transação à instância do analisador

//         }

//         analisador.ExibirRelatorio();
//     }
// }








// using initial.SoftwareFila;

// Fila cf = new Fila();

// string opcao;

// while (true)
// {
//     Console.WriteLine("Fila Online");
//     Console.WriteLine("atender");
//     Console.WriteLine("adicionar");
//     Console.WriteLine("listar");
//     Console.WriteLine("encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             cf.Atendimento();
//             break;
//         case "2":
//             cf.AdicionarFilaNormal();
//             break;
//             case "3":
//             cf.AdicionarClientePriori();
//             break;
//         case "4":
//             cf.Mostrarfila();
//             break;
//         case "5":
//             Console.WriteLine("Encerrando..");



// using initial.FARMACIA;

// FARMACIA1 fm = new FARMACIA1();

// string opcao;

// while (true)
// {Console.WriteLine("=============================================");
// Console.WriteLine("   ~~~ .: BEM-VINDO AO SISTEMA FARMÁCIA :. ~~~");
// Console.WriteLine("=============================================\n");

// Console.WriteLine("Digite abaixo a opção desejada:\n");

// Console.WriteLine(" [1] - Realizar Venda");
// Console.WriteLine(" [2] - Cadastrar Novo Medicamento");
// Console.WriteLine(" [3] - Cadastrar Novo Cliente");
// Console.WriteLine(" [4] - Editar Clientes");
// Console.WriteLine(" [5] - Editar Medicamentos");
// Console.WriteLine(" [6] - Listar Clientes Cadastrados");
// Console.WriteLine(" [7] - Listar Medicamentos Cadastrados");
// Console.WriteLine(" [8] - Remover Clientes Cadastrados");
// Console.WriteLine(" [9] - Remover Medicamentos Cadastrados");
// Console.WriteLine(" [0] - Encerrar Sistema");

// Console.Write("\nOpção: ");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             fm.Venda();
//             break;
//         case "2":
//             fm.CadastrarMedicamento();
//             break;
//         case "3":
//             fm.CadastrarCliente();
//             break;
//         case "4":
//             fm.EditarCliente();
//             break;
//         case "5":
//             fm.EditarMedicamento();
//             break;
//         case "6":
//             fm.ListarClientes();
//             break;
//         case "7":
//             fm.ListarMedicamento();
//             break;
//         case "8":
//             fm.RemoverCliente();
//             break;
//         case "9":
//             fm.RemoverProduto();
//             break;
//         case "0":
//             Console.WriteLine("...ENCERRANDO SISTEMA ...");
//             return;
//         default:
//             Console.WriteLine("Opção Invalida , tente uma opção válida!");
//             break;
            

//     }

// }













































