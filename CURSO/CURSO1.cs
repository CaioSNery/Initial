using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using initial.AUTOESCOLA;

namespace initial.CURSO
{
    public class CURSO1
    {
        public string Nome { get; set; }
        public List<PESSOA> Alunos { get; set; }

        public void AdicionarAluno(PESSOA aluno)
        {
            Alunos.Add(aluno);
        }


        public int QuantidadeDeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }



        public bool RemoveAluno(PESSOA aluno)
        {
            return Alunos.Remove(aluno);
        }



        public void ListarAlunos()


        {
            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "Nº" + count + " - " + Alunos[count].Nome;
                string texto = $"Nº {count + 1} - {Alunos[count].Nome}";
                Console.WriteLine(texto);
            }
        }
        
    }
    
}