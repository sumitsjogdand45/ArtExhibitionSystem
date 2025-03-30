using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.UpdateArtist
{
    public record UpdateArtistCommand(Artists artists):IRequest<Artists>;
    
}
