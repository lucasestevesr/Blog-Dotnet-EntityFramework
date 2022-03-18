using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogLucasEntityFramework.Models
{
    [Table("Category")]
    public class Category
    {
        // [DataAnNotations] Serve para schemas pequenos. Não é interessante para projeto compartilhados, visto que caso vc crie um dependência terá q importar o data Annotation também
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Chave gerada diretamente no banco.
        public int Id { get; set; } // o Entity já entende que o campo é uma FK
        
        [Required] // Is not Null. 
        [MinLength(3)]
        [MaxLength(80)] // Depara!  Logo tem que ser igual ao que está no banco!
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)] 
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
       
       
    }
}