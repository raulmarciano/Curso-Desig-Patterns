using CursoDesignPatterns.ChainResponsibility;
using CursoDesignPatterns.Strategy;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Imposto

            Console.WriteLine("Strategy:");

            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500);

            CalculadorImposto calculador = new CalculadorImposto();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);

            Console.ReadKey();

            #endregion Imposto

            #region ChainResponsibility

            Console.WriteLine("\nChain of Responsibility:");

            CalculadorDesconto calculadorDesconto = new CalculadorDesconto();

            orcamento.AdicionaItem(new Item("Caneta", 133));
            orcamento.AdicionaItem(new Item("Lapis", 133));

            calculadorDesconto.Calcula(orcamento);

            orcamento.AdicionaItem(new Item("TV", 133));
            orcamento.AdicionaItem(new Item("Xbox", 133));
            orcamento.AdicionaItem(new Item("PS5", 133));
            orcamento.AdicionaItem(new Item("Ryzen", 133));

            calculadorDesconto.Calcula(orcamento);
            Console.ReadKey();

            #endregion ChainResponsibility
        }
    }
}
