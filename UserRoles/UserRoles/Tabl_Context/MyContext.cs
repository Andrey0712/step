using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoles.Tabl_Context
{
    public class MyContext : DbContext
    {
       
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=andreydb;Username=andrey;Password=$544$B77w**G)K$t!Ube22}xa");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(tp => new { tp.UserId, tp.RoleId });

                userRole.HasOne(tp => tp.User)
                    .WithMany(t => t.UserRoles)
                    .HasForeignKey(tp => tp.UserId)
                    .IsRequired();

                userRole.HasOne(tp => tp.Role)
                    .WithMany(t => t.UserRoles)
                    .HasForeignKey(tp => tp.RoleId)
                    .IsRequired();
            });
        }
    }
}
