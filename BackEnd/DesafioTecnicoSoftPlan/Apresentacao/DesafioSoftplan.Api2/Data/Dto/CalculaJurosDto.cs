using System.ComponentModel.DataAnnotations;

namespace DesafioSoftplan.Api2.Data.Dto
{
    public class CalculaJurosDto
    {
        [Required(ErrorMessage = "Parâmetro Valor é obrigatório")]
        [Range(1, double.MaxValue, ErrorMessage = "Tempo deve ser um mês valido ")]
        public decimal ValorInicial { get; set; }
        [Required(ErrorMessage = "Parâmetro Meses é obrigatório")]
        [Range(1, 12, ErrorMessage = "Parâmetro Meses deve ser um mês valido ")]
        public int Meses { get; set; }

    }
}
