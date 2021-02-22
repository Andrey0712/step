using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAvto
{
    public class MyContext : DbContext
    {
        
        public DbSet<Avto> Avtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=andreydb;Username=andrey;Password=$544$B77w**G)K$t!Ube22}xa");
        }
    }
}
