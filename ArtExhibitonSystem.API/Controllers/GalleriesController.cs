using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllGalleries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtExhibitionSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleriesController : ControllerBase
    {
        readonly IMediator _mediator;
        public GalleriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGalleries()
        {
             var allgaleries= await _mediator.Send(new GetAllGalleriesQuery());
            return  Ok(allgaleries);
        }


    }
}
