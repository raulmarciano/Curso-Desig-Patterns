using System;

namespace CursoDesignPatterns.Strategy
{
    public interface IImposto
    {
        Double Calcula(Orcamento orcamento);
    }
}
