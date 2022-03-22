using System.ComponentModel.DataAnnotations;

namespace DesafioSoftplan.Api2.Data.Dto
{
    public class CalculaJurosDto
    {
        [Required(ErrorMessage = "Parâmetro Valor é obrigatório")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Parâmetro Meses é obrigatório")]
        public int Meses { get; set; }

    }
}
