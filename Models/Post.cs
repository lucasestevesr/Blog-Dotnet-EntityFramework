using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogLucasEntityFramework.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; } // FK
        public Category Category { get; set; } // Navigation Propety
        
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; } // FK
        public User Author { get; set; } // Navigation Propety
    }
}