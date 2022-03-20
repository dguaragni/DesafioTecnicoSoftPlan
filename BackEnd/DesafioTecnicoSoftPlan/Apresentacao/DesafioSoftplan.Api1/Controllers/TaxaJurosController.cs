using Microsoft.AspNetCore.Mvc;
using DesafioSoftplan.Api1.Aplicacao;

namespace DesafioSoftplan.Api1.Controllers
{
    [ApiController]
    [Route("taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {

        private readonly ILogger<TaxaJurosController> _logger;
        private ITaxaJurosApl _taxaJurosApl;

        public TaxaJurosController(ILogger<TaxaJurosController> logger, ITaxaJurosApl taxaJurosApl)
        {
            _logger = logger;
            _taxaJurosApl = taxaJurosApl;
        }

        [HttpGet(Name = "taxaJuros")]
        public IActionResult Get()
        {
            return Ok(_taxaJurosApl.ObtemTaxaJuros());
        }
    }
}