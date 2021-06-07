using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Api.Domain.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column("LastName")]
        public string LastName { get; set; }

        [field: NonSerialized]
        [Column("Password")]
        public string Password { get; set; }

        [Column("Role")]
        public string Role { get; set; }
    }
}