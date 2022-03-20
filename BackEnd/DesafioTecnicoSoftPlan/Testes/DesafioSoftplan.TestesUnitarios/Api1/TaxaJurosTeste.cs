using DesafioSoftplan.Api1.Aplicacao;
using Xunit;

namespace DesafioSoftplan.TestesUnitarios.Api1
{
    public class TaxaJurosTeste
    {
        [Fact]
        public void TestaValorFixoTaxaJuros()
        {
            // Arrange 
            var taxaJuros = new TaxaJurosApl();
            
            // Act 
            var resultado = taxaJuros.ObtemTaxaJuros();

            //Assert
            Assert.Equal(0.01M, resultado.TaxaJuros);

        }
    }
}