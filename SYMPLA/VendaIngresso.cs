using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.SYMPLA
{
    public class VendaIngresso
    {
        public List<ClienteShow> shows = new List<ClienteShow>();


        public void Venda()
        {
            Console.WriteLine("Digite seu Nome completo :");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu ano de nascimento : ");
            int year = int.Parse(Console.ReadLine());

            int nyear = 2025 - year ;

            if (nyear >= 18)
            {
                Console.WriteLine(" ENTRADA PERMITIDA ");
                return;
            }


            else
            {
                Console.WriteLine("Possui autorização dos pais ? \n  ' S/N '  ?");
                string resp = Console.ReadLine();

                if (resp == "s")
                {
                    Console.WriteLine("ENTRADA LIBERADA");
                    return;
                }
                else
                {
                    Console.WriteLine("ENTRADA NEGADA");
                    return;
                }

            }
            
            
             



            


        }

    
    }
}