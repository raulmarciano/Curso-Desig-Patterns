using CursoDesignPatterns.ChainResponsibility;
using CursoDesignPatterns.Strategy;
using CursoDesignPatterns.TemplateMethod;
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

            #region TemplateMethod

            //Usado para obrigar algumas implementações

            Console.WriteLine("\nTemplate Method:");

            IImposto icpp = new ICPP();
            IImposto ickv = new IKCV();

            double valorIcpp = icpp.Calcula(orcamento);
            double valorIckv = ickv.Calcula(orcamento);

            Console.WriteLine(valorIcpp);
            Console.WriteLine(valorIckv);

            Console.ReadKey();

            #endregion TemplateMethod

            #region Decorator

            Decorator.Imposto imposto = new Decorator.ISS(new Decorator.ICMS());
            double valor = imposto.Calcula(orcamento);

            Console.WriteLine($"\nDecorator\n{valor}");
            Console.ReadKey();

            #endregion Decorator


        }
    }
}
