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
            using (var context = new BlogDataContext())
            {
                //Create
                // var tag = new Tag
                // {
                //     Name = "Asp.Net",
                //     Slug = "aspnet"
                // };
                // context.Tags.Add(tag);                
                // context.SaveChanges();

                //Rehidratação - Update
                // var tag = context.Tags.FirstOrDefault( x=> x.Id == 1);
                // tag.Name = ".Net";
                // tag.Slug = "dotnet";
                // context.Update(tag);
                // context.SaveChanges();

                //Delete - USAR TRY CATCH
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1008);
                // context.Remove(tag);
                // context.SaveChanges();

                //SELECT
                //var tags = context.Tags; //Não executou no banco - referência 
                // var tags = context.Tags.AsNoTracking().Where( x=> x.Name.Contains(".Net")).ToList(); //Aqui eu estou obrigando a execução, o ToList() no final da query

                // foreach (var tag in tags) // Aqui executou no banco
                // {
                //     Console.WriteLine(tag.Name);
                // }

                var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 1513131);
                Console.WriteLine(tag?.Name);

            }
        }
    }
}