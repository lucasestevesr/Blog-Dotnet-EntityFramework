using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogLucasEntityFramework.Models
{
    [Table("tag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        // [Write(false)]
        // public List<Post> Posts { get; set; }
    }
}