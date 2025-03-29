using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.domain;
using ArtExhibitionSystem.Domain;
using ArtExhibitionSystem.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionSystem.Infrastructure.Context
{
    public class ArtDBContext:DbContext
    {
        public ArtDBContext(DbContextOptions<ArtDBContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistsConfiguration());
            modelBuilder.ApplyConfiguration(new ArtworkConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Artworks> Artworks { get; set; }
        public DbSet<FavoriteArtWork> FavoriteArtWork { get; set; }
        public DbSet<Galleries> Galleries  { get; set; }
        public DbSet<ArtworkGallery> ArtworkGallery { get; set; }






    }
}
