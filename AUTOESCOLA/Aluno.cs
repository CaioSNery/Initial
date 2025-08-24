using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.AUTOESCOLA
{
    public class Aluno
    {
        public string Nome;
        public string Cpf;
        public string DataProva;
        public string Instrutor;

        public Aluno(string cpfAluno, string nomeAluno, string dataAluno, string instrutor)
        {
            Nome = nomeAluno;
            Cpf = cpfAluno;
            DataProva = dataAluno;
            Instrutor = instrutor;
            
        }
    }
}


    