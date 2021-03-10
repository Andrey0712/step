using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_library
{
    
        public class MyContext : DbContext
        {

            public DbSet<Film> Films { get; set; }
        public DbSet<FilterName> FilterNames { get; set; }
        public DbSet<FilterValue> FilterValues { get; set; }
        public DbSet<FilterNameGroup> FilterNameGroups { get; set; }
        public DbSet<Filter> Filters { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=andreydb;Username=andrey;Password=$544$B77w**G)K$t!Ube22}xa");
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<FilterNameGroup>(filterNG =>
            {
                filterNG.HasKey(f => new { f.FilterValueId, f.FilterNameId });

                filterNG.HasOne(ur => ur.FilterNameOf)
                    .WithMany(r => r.FilterNameGroups)
                    .HasForeignKey(ur => ur.FilterNameId)
                    .IsRequired();

                filterNG.HasOne(ur => ur.FilterValueOf)
                    .WithMany(r => r.FilterNameGroups)
                    .HasForeignKey(ur => ur.FilterValueId)
                    .IsRequired();
            });

            modelBuilder.Entity<Filter>(filter =>
            {
                filter.HasKey(f => new { f.FilmId, f.FilterValueId, f.FilterNameId });

                filter.HasOne(ur => ur.FilterNameOf)
                    .WithMany(r => r.Filters)
                    .HasForeignKey(ur => ur.FilterNameId)
                    .IsRequired();

                filter.HasOne(ur => ur.FilterValueOf)
                    .WithMany(r => r.Filters)
                    .HasForeignKey(ur => ur.FilterValueId)
                    .IsRequired();

                filter.HasOne(ur => ur.FilmOf)
                    .WithMany(r => r.Filters)
                    .HasForeignKey(ur => ur.FilmId)
                    .IsRequired();
            });

        }
    }
   
}
