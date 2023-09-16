﻿namespace BlazorEcommerce.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Fellowship of the Ring",
                    Description = "The Fellowship of the Ring is the first of three volumes of the epic novel[2] The Lord of the Rings by the English author J. R. R. Tolkien. It is followed by The Two Towers and The Return of the King. The action takes place in the fictional universe of Middle-earth. The book was first published on 29 July 1954 in the United Kingdom. The volume consists of a foreword, in which the author discusses his writing of The Lord of the Rings, a prologue titled \"Concerning Hobbits, and other matters\", and the main narrative in Book I and Book II. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8e/The_Fellowship_of_the_Ring_cover.gif",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "The Two Towers",
                    Description = "The Two Towers is the second volume of J. R. R. Tolkien's high fantasy novel The Lord of the Rings. It is preceded by The Fellowship of the Ring and followed by The Return of the King. The volume's title is ambiguous, as five towers are named in the narrative, and Tolkien himself gave conflicting identifications of the two towers. The narrative is interlaced, allowing Tolkien to build in suspense and surprise. The volume was largely welcomed by critics, who found it exciting and compelling, combining epic narrative with heroic romance. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a1/The_Two_Towers_cover.gif",
                    Price = 8.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "The Return of the King",
                    Description = "The Return of the King is the third and final volume of J. R. R. Tolkien's The Lord of the Rings, following The Fellowship of the Ring and The Two Towers. It was published in 1955. The story begins in the kingdom of Gondor, which is soon to be attacked by the Dark Lord Sauron. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/11/The_Return_of_the_King_cover.gif",
                    Price = 6.99m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
