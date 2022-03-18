using System;
using BlogLucasEntityFramework.Data;
using BlogLucasEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogLucasEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // var user = new User
            // {
            //     Name = "Lucas Esteves",
            //     Slug = "lucasesteves",
            //     Email = "Lucas@gmail.com",
            //     Bio = "oi.",
            //     Image = "https://img.io",
            //     PasswordHash = "12345678"
            // };

            // var category = new Category
            // {
            //     Name = "MicroServices",
            //     Slug = "micro-services"
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category, 
            //     // Referência a 2 itens que não existem ainda.
            //     // Na hora de inserir o Usuário e a Categoria ele vai pegar os
            //     // ids para inserir o Post. Tudo de forma transacionada.
            //     Body = "<p>Hello World</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigos vamos aprender EF core",
            //     Title = "Coemçando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            // var posts = context
            //     .Posts
            //     .AsNoTracking() // Não persistir no banco
            //     .Include(x => x.Author) // INNER JOIN
            //     .Include(x => x.Category) // INNER JOIN
            //         // .ThenInclude(x => x.Slug) // SUBSELECT (não é mto bom)
            //         // O ThenInclude é associado ao filho, Está associado a Categoria agora e não a Posts 
            //     .OrderByDescending(x => x.LastUpdateDate)
            //     .ToList(); 

            // foreach (var post in posts)
            // {
            //     Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
            // }


            var post= context
               .Posts
             //.AsNoTracking()
                .Include(x => x.Author) // INNER JOIN
                .Include(x => x.Category) // INNER JOIN
                                       // .ThenInclude(x => x.Slug) // SUBSELECT (não é mto bom)
                                       // O ThenInclude é associado ao filho, Está associado a Categoria agora e não a Posts 
                .OrderByDescending(x => x.LastUpdateDate)
                .FirstOrDefault(); // Pegando o primeiro Item.

            post.Author.Name = "João Autor"; // Trocou o nome do usuário estando no contexto de Post. pelas propriedades de navegação.

            context.Posts.Update(post);
            context.SaveChanges();
        }
    }
}