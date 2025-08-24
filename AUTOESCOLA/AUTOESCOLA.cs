using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.AUTOESCOLA
{
    class AUTOESCOLA
    {
        private List<Aluno> alunos;
        private string datadaprova;



        public AUTOESCOLA(string datadaprova)
        {
            this.datadaprova = datadaprova;
            alunos = new List<Aluno>();
        }
        public void AdicionarAluno()
{
    Console.WriteLine("Digite o nome do aluno:");
    string nomeAluno = Console.ReadLine();

    Console.WriteLine("Digite o CPF:");
    string cpfAluno = Console.ReadLine();

    Console.WriteLine("Digite a data da prova para este aluno (ex: 25/05/2025):");
    string dataAluno = Console.ReadLine();

            Console.WriteLine("Digite o nome do instrutor responsavél :");
            string instrutor = Console.ReadLine();

            Aluno novoAluno = new Aluno(cpfAluno, nomeAluno, dataAluno, instrutor);
    

    alunos.Add(novoAluno);

    Console.WriteLine($"Aluno {nomeAluno} com CPF {cpfAluno} e data da prova: {dataAluno} Instrutor responsavél:{instrutor} ,cadastrado com sucesso!");
}

        public void RemoveAluno()
        {
            Console.WriteLine("Para Remover um aluno digite seu nome");
            string nomeAluno = Console.ReadLine();

            Aluno AlunoEncontrado = alunos.Find(a => a.Nome.Equals(nomeAluno, StringComparison.OrdinalIgnoreCase));
            if (AlunoEncontrado != null)
            {
                alunos.Remove(AlunoEncontrado);
                Console.WriteLine($"Aluno {nomeAluno} removido com sucesso");
            }
            else
            {
                Console.WriteLine("Aluno nao encontrado !");
            }
    }

  
            public void ListarAlunos()
        {

            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum Aluno Cadastrado !");
                return;
            }
            Console.WriteLine("Lista de Alunos Cadastrados : ");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"-NOME {aluno.Nome} -CPF{aluno.Cpf} Instrutor:{aluno.Instrutor} - Data da Prova{aluno.DataProva}");
            }
        }
    

    }
}