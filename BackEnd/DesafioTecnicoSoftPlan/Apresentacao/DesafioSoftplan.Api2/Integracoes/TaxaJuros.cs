using DesafioSoftplan.Api2.Data.Dto;

namespace DesafioSoftplan.Api2.Integracoes
{
    public class TaxaJuros : ITaxaJuros
    {
        private HttpClient _httpClient;
        private IConfiguration _configuration;
        public TaxaJuros(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<decimal> ObtemTaxaJuros()
        {
            var urlApiTaxaJuros = _configuration["UrlApiTaxaJuros"];
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(new Uri(urlApiTaxaJuros));
                ResultadoTaxaJurosDto? resultado = await response.Content.ReadFromJsonAsync<ResultadoTaxaJurosDto>();
                return resultado == null ? 0 : resultado.TaxaJuros;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel obter a taxa de juros atual. " + ex.Message, ex);
            }
        }
    }
}
