using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionSystem.Infrastructure.Repository
{
    public class FavouriteArtWorkRepository : IFavoriteArtWorkRepository
    {
        readonly ArtDBContext _artDbContext;
        public FavouriteArtWorkRepository(ArtDBContext artDbContext)
        {
            _artDbContext = artDbContext;
        }

        //getall
        public async Task<IEnumerable<FavoriteArtWork>>GetAllFavoriteArtwork()
        {
            return await _artDbContext.FavoriteArtWork.ToListAsync();
        }
    }
}
