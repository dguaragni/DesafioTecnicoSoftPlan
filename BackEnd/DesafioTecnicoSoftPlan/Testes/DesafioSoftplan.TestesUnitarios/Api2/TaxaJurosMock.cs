using DesafioSoftplan.Api2.Integracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.TestesUnitarios.Api2
{
    internal class TaxaJurosMock : ITaxaJuros
    {
        public Task<decimal> ObtemTaxaJuros()
        {
            decimal taxaJuros = 0.01M;
            return Task.FromResult(taxaJuros);
        }
    }
}
