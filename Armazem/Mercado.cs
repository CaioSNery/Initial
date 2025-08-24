using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initial.CadastroProduto
{
    public class Mercado
    {
        public List<Produto> produto = new List<Produto>();
        public int estoque;



        public void Armazem()
        {
            Console.WriteLine("~~ DIGITE O NOME DO PRODUTO ~~");
            string nome = Console.ReadLine();


            Console.WriteLine("~~ VALOR EM UNIDADES ~~");
            string entrada = Console.ReadLine();

            Console.WriteLine("~~QUANTIDADE A SER ARMAZENADA ~~");
            int estoque = int.Parse(Console.ReadLine());



            if (decimal.TryParse(entrada, out decimal Preco))
            {
                //Com as informações passada cria o OBJETO(novoProduto)
                // new Produto e coloca os atributos do OBJETO
                Produto novoProduto = new Produto(nome, Preco, estoque);
                produto.Add(novoProduto);
                Console.WriteLine($" # Produto  {nome} - {estoque} UNID(s). , valor por unidade R${Preco:F2}");
            }
            else
            {
                Console.WriteLine("Valor Inválido !"); 
                
            }

        }

        public void Listar()
        //produto list = Class Produto. Da as Variáveis [set;get;]
        //Nome = nome.Estoque=estoque ..quando ele rodar a lista ele pega todos os atributos
        //e coloca Nome: , Preco: Estoque:...
        // Produto novoProduto = new Produto(nome, Preco, estoque);
        //produto.Add(novoProduto);
        {
            if (produto.Count > 0)
            {
                Console.WriteLine("~~ PRODUTOS ARMAZENADOS~~");
                foreach (var lista in produto)
                {
                    Console.WriteLine(lista);

                }
            }
            else
            {
                Console.WriteLine("Armazem esta vazio ;(");
            }
        }
        public void Venda()
{
    Console.WriteLine("~~INFORME NOME DO PRODUTO ~~");
    string nome = Console.ReadLine();

    Console.WriteLine("~~QUANTIDADE~~");
    int quantidadeVendida = int.Parse(Console.ReadLine());

    Produto produtoParaVender = produto.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

    if (produtoParaVender != null)
    {
        if (produtoParaVender.Estoque >= quantidadeVendida)
        // .Estoque usa o get;set; pra ver quanto tem em estoque.
        {
            produtoParaVender.Estoque -= quantidadeVendida;
            Console.WriteLine($"Venda efetuada com sucesso: {quantidadeVendida} unidade(s) de {produtoParaVender.Nome} vendida(s) por R${produtoParaVender.Preco:F2} cada.");
            Console.WriteLine($"Estoque atual: {produtoParaVender.Estoque} unidade(s).");

            // Se o estoque zerar, opcionalmente remover da lista
            if (produtoParaVender.Estoque == 0)
            {
                produto.Remove(produtoParaVender);
                Console.WriteLine("Produto removido do estoque (estoque zerado).");
            }
        }
        else
        {
            Console.WriteLine("Estoque insuficiente para realizar a venda.");
        }
    }
    else
    {
        Console.WriteLine("Produto não cadastrado.");
    }
}

        }
    }
