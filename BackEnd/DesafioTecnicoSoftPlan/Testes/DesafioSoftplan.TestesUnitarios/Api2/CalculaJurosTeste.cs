using DesafioSoftplan.Api2.Aplicacao;
using DesafioSoftplan.Api2.Data.Dto;
using DesafioSoftplan.Api2.Integracoes;
using Xunit;

namespace DesafioSoftplan.TestesUnitarios.Api2
{
    public class CalculaJurosTeste
    {
        [Theory]
        [InlineData(100, 5, 105.10)]
        [InlineData(300, 10, 331.39)]
        [InlineData(400, 2, 408.04)]
        public async void TestaCalculoTaxaJuros(decimal valorInicial, int meses, decimal valorFinal)
        {
            // Arrange 
            var taxaJuros = new TaxaJurosMock();
            var calculaJuros = new CalculaJurosApl(taxaJuros);
            var calculaJurosDto = new CalculaJurosDto() { ValorInicial = valorInicial, Meses = meses };

            // Act 
            var resultado = await calculaJuros.CalculaJuros(calculaJurosDto);

            //Assert
            Assert.Equal(valorFinal, resultado.ValorFinal);

        }
    }
}