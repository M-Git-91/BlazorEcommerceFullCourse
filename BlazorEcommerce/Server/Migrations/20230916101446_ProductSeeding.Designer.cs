﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230916101446_ProductSeeding")]
    partial class ProductSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Fellowship of the Ring is the first of three volumes of the epic novel[2] The Lord of the Rings by the English author J. R. R. Tolkien. It is followed by The Two Towers and The Return of the King. The action takes place in the fictional universe of Middle-earth. The book was first published on 29 July 1954 in the United Kingdom. The volume consists of a foreword, in which the author discusses his writing of The Lord of the Rings, a prologue titled \"Concerning Hobbits, and other matters\", and the main narrative in Book I and Book II. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8e/The_Fellowship_of_the_Ring_cover.gif",
                            Price = 9.99m,
                            Title = "The Fellowship of the Ring"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Two Towers is the second volume of J. R. R. Tolkien's high fantasy novel The Lord of the Rings. It is preceded by The Fellowship of the Ring and followed by The Return of the King. The volume's title is ambiguous, as five towers are named in the narrative, and Tolkien himself gave conflicting identifications of the two towers. The narrative is interlaced, allowing Tolkien to build in suspense and surprise. The volume was largely welcomed by critics, who found it exciting and compelling, combining epic narrative with heroic romance. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a1/The_Two_Towers_cover.gif",
                            Price = 8.99m,
                            Title = "The Two Towers"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Return of the King is the third and final volume of J. R. R. Tolkien's The Lord of the Rings, following The Fellowship of the Ring and The Two Towers. It was published in 1955. The story begins in the kingdom of Gondor, which is soon to be attacked by the Dark Lord Sauron. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/11/The_Return_of_the_King_cover.gif",
                            Price = 6.99m,
                            Title = "The Return of the King"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
