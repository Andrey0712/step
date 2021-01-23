using Microsoft.EntityFrameworkCore;


namespace User_tel
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=andreydb;Username=andrey;Password=$544$B77w**G)K$t!Ube22}xa");
        }

    }
}
