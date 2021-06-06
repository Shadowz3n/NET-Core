using System.ComponentModel.DataAnnotations;

namespace app.Api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Inválida")]
        public decimal Price { get; set; }


        public Category Category { get; set; }
    }
}