﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddArtist
{
    public record AddArtistCommand(Artists artistId) :IRequest<Artists>;
     
}
