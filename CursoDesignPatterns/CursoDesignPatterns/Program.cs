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
        }
    }
}
