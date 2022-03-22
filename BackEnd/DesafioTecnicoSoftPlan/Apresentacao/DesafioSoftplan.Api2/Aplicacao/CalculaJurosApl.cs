using DesafioSoftplan.Api2.Data.Dto;
using DesafioSoftplan.Api2.Integracoes;

namespace DesafioSoftplan.Api2.Aplicacao
{
    public class CalculaJurosApl : ICalculaJurosApl
    {
        private readonly ITaxaJuros _taxaJuros;
        
        public CalculaJurosApl(ITaxaJuros taxaJuros)
        {
            _taxaJuros = taxaJuros;
        }

        public async Task<ResultadoCalculaJurosDto> CalculaJuros(CalculaJurosDto dadosCalculaJuros)
        {
            var taxaJuros = (1 + await _taxaJuros.ObtemTaxaJuros());
            taxaJuros = (decimal)Math.Pow((double)taxaJuros, (double)dadosCalculaJuros.Meses);

            var resultado = dadosCalculaJuros.Valor * taxaJuros;
            resultado = decimal.Round(resultado, 2);

            return new ResultadoCalculaJurosDto() { ValorFinal = resultado };
        }

    }
}
