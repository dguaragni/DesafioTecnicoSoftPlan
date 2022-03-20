using DesafioSoftplan.Api1.Data.Dto;

namespace DesafioSoftplan.Api1.Aplicacao
{
    public class TaxaJurosApl : ITaxaJurosApl
    {
        private readonly decimal TAXA_JUROS = 0.01M;

        public TaxaJurosDto ObtemTaxaJuros()
        {
            return new TaxaJurosDto() { TaxaJuros = TAXA_JUROS };
        }
    }

}
