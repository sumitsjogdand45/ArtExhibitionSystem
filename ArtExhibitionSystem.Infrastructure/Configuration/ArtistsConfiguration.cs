using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    ArtistName = "Sumit",ArtistPhone=""
                    
                },
                 new Artists
                 {
                     ArtistID = 2,
                     ArtistName = "Kapil",
                     ArtistPhone=""
                 });
        }
    }
}
