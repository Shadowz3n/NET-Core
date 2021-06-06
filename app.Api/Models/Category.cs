using System.ComponentModel.DataAnnotations;

namespace app.Api.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Title { get; set; }
    }
}