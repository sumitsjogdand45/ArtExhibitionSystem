using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetArtworkByIdQuery
{
    public record GetArtworkByIdQuery(int artworkId):IRequest<Artworks>;
}
