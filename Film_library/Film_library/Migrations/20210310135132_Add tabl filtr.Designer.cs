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
    [Migration("20210310135132_Add tabl filtr")]
    partial class Addtablfiltr
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

            modelBuilder.Entity("Film_library.Filter", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("integer");

                    b.Property<int>("FilterValueId")
                        .HasColumnType("integer");

                    b.Property<int>("FilterNameId")
                        .HasColumnType("integer");

                    b.HasKey("FilmId", "FilterValueId", "FilterNameId");

                    b.HasIndex("FilterNameId");

                    b.HasIndex("FilterValueId");

                    b.ToTable("tblFilters");
                });

            modelBuilder.Entity("Film_library.FilterName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("tblFilterNames");
                });

            modelBuilder.Entity("Film_library.FilterNameGroup", b =>
                {
                    b.Property<int>("FilterValueId")
                        .HasColumnType("integer");

                    b.Property<int>("FilterNameId")
                        .HasColumnType("integer");

                    b.HasKey("FilterValueId", "FilterNameId");

                    b.HasIndex("FilterNameId");

                    b.ToTable("tblFilterNameGroups");
                });

            modelBuilder.Entity("Film_library.FilterValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("tblFilterValues");
                });

            modelBuilder.Entity("Film_library.Filter", b =>
                {
                    b.HasOne("Film_library.Film", "FilmOf")
                        .WithMany("Filters")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Film_library.FilterName", "FilterNameOf")
                        .WithMany("Filters")
                        .HasForeignKey("FilterNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Film_library.FilterValue", "FilterValueOf")
                        .WithMany("Filters")
                        .HasForeignKey("FilterValueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Film_library.FilterNameGroup", b =>
                {
                    b.HasOne("Film_library.FilterName", "FilterNameOf")
                        .WithMany("FilterNameGroups")
                        .HasForeignKey("FilterNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Film_library.FilterValue", "FilterValueOf")
                        .WithMany("FilterNameGroups")
                        .HasForeignKey("FilterValueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
