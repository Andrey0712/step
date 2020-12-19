using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creat_DB
{
    public class MyContext : DbContext

    {
       

        public DbSet<Tag> tags { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<PostTagMap> postMapTags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=andreydb;Username=andrey;Password=$544$B77w**G)K$t!Ube22}xa");
        }

    }
}
