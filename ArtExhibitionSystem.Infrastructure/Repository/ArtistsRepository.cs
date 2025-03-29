using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;


namespace ArtExhibitionSystem.Infrastructure.Repository
{
    public class ArtistsRepository: IArtistsRepository
    {
        readonly ArtDBContext  _artDbContext;

        public ArtistsRepository(ArtDBContext artDbContext)
        {
            _artDbContext=artDbContext;
        }


       
    }
}
