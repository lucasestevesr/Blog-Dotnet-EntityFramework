using BlogLucasEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogLucasEntityFramework.Data
{

    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; } 
        public DbSet<User> Users { get; set; }

        // Entity Framework por padrão não entende entidades que não sejam primary key
 
        // Metódo utulizado para configurar o EF core
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
             options.UseSqlServer(@"Server=localhost,1433;Database=BlogLucas;User ID=sa;Password=Rkpzlx56!!;TrustServerCertificate=True");
             options.LogTo(Console.WriteLine); //Info sobre a exec, como a query feita no sql por exemplo.
        }

        
        
    }
}
