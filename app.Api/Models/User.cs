using System;
using System.ComponentModel.DataAnnotations;

namespace app.Api.Models
{
    [Serializable]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string LastName { get; set; }

        [field: NonSerialized]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}