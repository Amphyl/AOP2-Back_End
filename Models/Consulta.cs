using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaConsultas.Models
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A especialidade é obrigatória.")]
        [StringLength(50)]
        public string Especialidade { get; set; }

        [Required(ErrorMessage = "A data e hora são obrigatórias.")]
        public DateTime DataHora { get; set; }

        [StringLength(500)]
        public string? Descricao { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }
    }
}