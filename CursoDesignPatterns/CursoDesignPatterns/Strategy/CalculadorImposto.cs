using System;

namespace CursoDesignPatterns.Strategy
{
    public class CalculadorImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valorImposto = imposto.Calcula(orcamento);
            Console.WriteLine(valorImposto);
        }
    }
}
