using ArtExhibitionSystem.domain;

namespace ArtExhibitionSystem.application.Interfaces
{
    public interface IGalleriesRepository
    {
        Task<IEnumerable<Galleries>> GetAllGalleries();
    }
}
