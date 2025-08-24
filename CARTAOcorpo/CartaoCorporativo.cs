using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.CARTAOcorpo
{
    public class CartaoCoporativo
    {
            public decimal Limite { get; }
    public List<decimal> Transacoes { get; }

    public CartaoCoporativo(decimal limite)
    {
        Limite = limite;
        Transacoes = new List<decimal>();
    }

    public void AdicionarTransacao(decimal valor)
    {
        Transacoes.Add(valor);
    }

    public decimal CalcularTotal()
    {
        return Transacoes.Sum();
        //.Sum soma soma todos os elementos de uma coleção numérica  
        // como uma lista de int, float, double, decimal.
    }

    public bool UltrapassouLimite()
    {
        return CalcularTotal() > Limite;
    }

    public void ExibirResumo()
    {
        decimal todo = CalcularTotal();
        Console.WriteLine($"Total gasto: {todo:F2}");
        if(UltrapassouLimite())
        {
          Console.WriteLine("Limite ultrapassado");
          
        }
        else
        {
          Console.WriteLine("Limite OK");
        }
    }
    }
}