using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.CURSO
{
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Executa primeiro , CLASS BASE");

        }

    }

    public class Derivada : Base
    {
        public Derivada()
        {
            Console.WriteLine("Executa SEGUNDO , CLASS HERDA BASE");
        }


    }
    public class Derivada2 : Derivada

    {
        public Derivada2()
        {
            Console.WriteLine("Executa TERCEIRO , HERDA CLASS DERIVADA1 QUE HERDA BASE");
        }
    }
}
