using ArtExhibitionSystem.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtExhibitionSystem.Infrastructure.Context
{
    public class ArtworkConfiguration : IEntityTypeConfiguration<Artworks>
    {

        public void Configure(EntityTypeBuilder<Artworks> builder)
        {
            builder.HasData(
                new Artworks
                {
                    ArtworkId = 1,
                    Title = "Painting",
                    CreationDate = DateTime.Now,
                    Description = "horse Painting",
                    ArtistId = 1,
                    //  Artists
                    ImageURL = "sdfqr"

                });
        }
    }
}