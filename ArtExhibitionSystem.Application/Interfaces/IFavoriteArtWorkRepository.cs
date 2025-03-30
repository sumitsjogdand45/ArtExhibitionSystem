using ArtExhibitionSystem.Domain;

namespace ArtExhibitionSystem.application.Interfaces
{
    public interface IFavoriteArtWorkRepository
    {
        Task<IEnumerable<FavoriteArtWork>>GetAllFavoriteArtwork();


    }
}
