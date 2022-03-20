using DesafioSoftplan.Api2.Data.Dto;

namespace DesafioSoftplan.Api2.Aplicacao
{
    public interface ICalculaJurosApl
    {
        Task<ResultadoCalculaJurosDto> CalculaJuros(CalculaJurosDto dadosCalculaJuros);
    }
}
