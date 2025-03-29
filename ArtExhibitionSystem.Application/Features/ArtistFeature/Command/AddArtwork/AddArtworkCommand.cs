using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddArtwork
{   
        public record AddArtworkCommand( Artworks artworkId) : IRequest<Artworks>;
   

}
