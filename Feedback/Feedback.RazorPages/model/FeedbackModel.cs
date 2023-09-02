using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.RazorPages.Models
{
    public class FeedbackModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? IdFeedback { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string? NomeCliente { get; set; }
        [Required(ErrorMessage = "Email é obrigatorio")]
        public string? EmailCliente { get; set; }
        [Required(ErrorMessage = "Data é obrigatorio")]
        [DisplayFormat(DataFormatString= "{0:dd MMM yyyy}")]
        public DateTime? DataFeedback { get; set; }
        [Required(ErrorMessage = "Comentario é obrigatorio")]
        public string? Comentario { get; set; }
        [Required(ErrorMessage = "Avaliacao é obrigatorio")]
        [Range(1, 5, ErrorMessage = "A avaliação deve estar entre 1 e 5.")]
        public int? Avaliacao { get; set; }
        public string DataFormatada
        {
            get
            {
                if (DataFeedback.HasValue)
                {
                    return DataFeedback.Value.ToString("dd MMM yyyy");
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}