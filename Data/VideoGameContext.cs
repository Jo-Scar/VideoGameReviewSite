using Microsoft.EntityFrameworkCore;
using VideoGameReviewSite.Models;

namespace VideoGameReviewSite.Data
{
    public class VideoGameContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connectionString = "Server=(localdb)\\mssqllocaldb:Database=VideGameLibvrary;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGameModel>().HasData(new VideoGameModel()
            {
                Id = 1,
                Name = "The Legend of Zelda: Breath of the Wild",
                Publisher = "Nintendo",
                Description = "An open-world action-adventure game set in the kingdom of Hyrule, where players control Link to defeat Calamity Ganon.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/5/51/The_Legend_of_Zelda_Breath_of_the_Wild_cover.png",
            });
            modelBuilder.Entity<VideoGameModel>().HasData(new VideoGameModel()
            {
                Id = 2,
                 Name = "The Witcher 3: Wild Hunt",
                 Publisher = "CD Projekt",
                 Description = "An open-world RPG where players control Geralt of Rivia, a monster hunter, as he searches for his adopted daughter.",
                 ImageURL = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Witcher_3_cover_art.jpg/250px-Witcher_3_cover_art.jpg"
            });            
        }
    }
}
