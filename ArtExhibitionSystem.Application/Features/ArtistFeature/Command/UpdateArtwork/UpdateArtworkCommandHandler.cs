using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.UpdateArtwork
{

    public class UpdateArtworkCommandHandler:IRequestHandler<UpdateArtworkCommand ,Artworks>
    {
        readonly IArtworkRepository _artworkRepository;

        public UpdateArtworkCommandHandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository=artworkRepository;
        }
        Task<Artworks> IRequestHandler<UpdateArtworkCommand, Artworks>.Handle(UpdateArtworkCommand request, CancellationToken cancellationToken)
        {
            var artworks = _artworkRepository.UpdateArtworkAsync(request.artwork);
            return artworks;
        }
    }
}
