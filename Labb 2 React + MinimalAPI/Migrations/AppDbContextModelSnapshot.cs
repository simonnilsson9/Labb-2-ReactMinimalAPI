﻿// <auto-generated />
using System;
using Labb__Minimal_API___Anrop_till_ASP.Net.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb_2_React___MinimalAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb__Minimal_API___Anrop_till_ASP.Net.Models.Book", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = new Guid("bf511146-1351-4be0-883f-2a44140f6c91"),
                            Author = "J.K. Rowling",
                            Description = "Book about Harry Potter and his wizarding friends.",
                            Genre = "Fantasy",
                            IsAvailable = true,
                            PublicationYear = 1999,
                            Title = "Harry Potter and the Prisoner of Azkaban"
                        },
                        new
                        {
                            ID = new Guid("1906cc51-9ca5-4847-9b2c-712a56d1aa28"),
                            Author = "Suzanne Collins",
                            Description = "We follow Katniss Everdeen and her struggles.",
                            Genre = "Science fiction",
                            IsAvailable = false,
                            PublicationYear = 2008,
                            Title = "The Hunger Games"
                        },
                        new
                        {
                            ID = new Guid("43c9c692-37ed-4ff8-8839-52cf5c30c194"),
                            Author = "Jordan Belfort",
                            Description = "About Jordan Belforts interesting life!",
                            Genre = "Autobiography",
                            IsAvailable = true,
                            PublicationYear = 2008,
                            Title = "Wolf of the Wall Street"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
