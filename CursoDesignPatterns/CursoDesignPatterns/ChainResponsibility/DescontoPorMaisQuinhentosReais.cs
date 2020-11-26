namespace CursoDesignPatterns.ChainResponsibility
{
    public class DescontoPorMaisQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 550)
                return orcamento.Valor * 0.07;

            return Proximo.Desconta(orcamento);
        }
    }
}
