
using ArtExhibitionSystem.Application.Models.Identity;

namespace ArtExhibitionSystem.Application.Interfaces.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest authRequest);
        Task<RegistrationResponse> Register(RegistrationRequest registrationRequest);
    }
}
