using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskapi.modles;
using tasknew.modles;


namespace Taskapi.dataaccess
{
    public class Tododbcontext:DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<author> Authors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=.;Database=mydatabase;Integrated Security=True;trustServerCertificate=true";  
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<author>().HasData(new author[]
                {
                    new author {AId=1,FullName="Thilina Dilshan",Addressno="31",street="Maliyadda",city="Hanguranketha",Joberole="Developer"},
                    new author {AId=2,FullName="Saduni Madubhashini",Addressno="48",street="Perawella",city="Welimada",Joberole="Accountant"},
                    new author {AId=3,FullName="Charith vishan",Addressno="23",street="mathugama",city="kaluthara",Joberole="Developer"},
                    new author {AId=4,FullName="Punsara Nishanga",Addressno="31",street="Maliyadda",city="Hanguranketha",Joberole="Driver"},
                });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
                {
            new Todo
            {
                Id = 1,
                Title = "Get books for school-DB",
                Description = "get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = Todostatus.New,
                authorAId=1
                
            },
            new Todo
            {
                Id = 2,
                Title = "Get Vegetable",
                Description = "get vegetable for week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = Todostatus.New,
                authorAId=1
                
            },
            new Todo
            {
                Id = 3,
                Title = "Water the plants",
                Description = "Wter the plant quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = Todostatus.New,
                authorAId=2
            }

                });
        }
    }
}
