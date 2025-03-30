using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllFavouriteArtwork;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtExhibitionSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteArtWorkController : ControllerBase
    {
        readonly IMediator _mediatoR;

        public FavoriteArtWorkController(IMediator mediator)
        {
            _mediatoR = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFavoriteArtwork()
        { 
            var result= await _mediatoR.Send(new GetAllFavouriteArtworkQuery());
            return Ok(result);
        }
    }
}
