namespace CursoDesignPatterns.ChainResponsibility
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.01;

            return Proximo.Desconta(orcamento);
        }
    }
}
