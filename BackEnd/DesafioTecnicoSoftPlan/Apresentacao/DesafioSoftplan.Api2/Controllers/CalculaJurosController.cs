using Microsoft.AspNetCore.Mvc;
using DesafioSoftplan.Api2.Aplicacao;
using DesafioSoftplan.Api2.Data.Dto;

namespace DesafioSoftplan.Api2.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class CalculaJurosController : ControllerBase
    {

        private readonly ILogger<CalculaJurosController> _logger;
        private readonly ICalculaJurosApl _aplCalculoJuros;

        public CalculaJurosController(ILogger<CalculaJurosController> logger, ICalculaJurosApl aplCalculoJuros)
        {
            _logger = logger;
            _aplCalculoJuros = aplCalculoJuros;
        }

        [HttpGet(Name = "calculajuros")]
        public async Task<IActionResult> Get([FromQuery]CalculaJurosDto calculaJurosDto)
        {
            return Ok(await _aplCalculoJuros.CalculaJuros(calculaJurosDto));
        }
    }
}