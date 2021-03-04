﻿// <auto-generated />
using Film_library;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Film_library.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210304082615_Add tbl Film")]
    partial class AddtblFilm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Film_library.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Actors")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tblFilm");
                });
#pragma warning restore 612, 618
        }
    }
}
