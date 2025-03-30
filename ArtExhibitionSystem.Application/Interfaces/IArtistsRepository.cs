using ArtExhibitionSystem.domain;
using ArtExhibitionSystem.Domain;

namespace ArtExhibitionSystem.application.Interfaces
{
    public interface IArtistsRepository
    {
        Task<IEnumerable<Artists>>GetAllArtists();
        Task<Artists> AddArtists(Artists artist);
        Task<Artists> GetArtistById(int artistId);
        Task<Artists> UpdateArtist(Artists  artists);
        Task<Artists> DeleteArtist(int artistId);


    }
}
