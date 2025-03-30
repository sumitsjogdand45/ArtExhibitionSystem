using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using ArtExhibitionSystem.Domain;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionSystem.Infrastructure.Repository
{
    public class GalleriesRepository : IGalleriesRepository
    {
        readonly ArtDBContext _artDBContext;
        public GalleriesRepository(ArtDBContext artDBContext)
        {
            _artDBContext=artDBContext;
        }

        //GetAllGalleries
        public async Task<IEnumerable<Galleries>> GetAllGalleries()
        {
            return await _artDBContext.Galleries.ToListAsync();
        }   
    }
}
