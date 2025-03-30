using ArtExhibitionSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtExhibitionSystem.Infrastructure.Configuration
{
    internal class ArtistsConfiguration : IEntityTypeConfiguration<Artists>
    {
        public void Configure(EntityTypeBuilder<Artists> builder)
        {
            builder.HasData(
                new Artists
                {
                    ArtistID = 1,
                    ArtistName = "Sumit",
                    ArtistPhone = "100",
                    ArtistBirthdate = new DateTime(2000,5,8)
                    

                },
                 new Artists
                 {
                     ArtistID = 2,
                     ArtistName = "Kapil",
                     ArtistPhone = "95456188188",
                     ArtistBirthdate = new DateTime(2001, 02, 05)
                 });
        }
    }
}
