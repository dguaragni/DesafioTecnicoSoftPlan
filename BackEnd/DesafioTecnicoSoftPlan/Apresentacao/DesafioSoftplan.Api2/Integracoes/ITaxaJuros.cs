namespace DesafioSoftplan.Api2.Integracoes
{
    public interface ITaxaJuros
    {
        Task<decimal> ObtemTaxaJuros();
    }
}
