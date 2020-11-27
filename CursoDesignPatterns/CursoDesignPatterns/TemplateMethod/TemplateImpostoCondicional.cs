using CursoDesignPatterns.Strategy;

namespace CursoDesignPatterns.TemplateMethod
{
    public abstract class TemplateImpostoCondicional : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (UsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        public abstract bool UsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
