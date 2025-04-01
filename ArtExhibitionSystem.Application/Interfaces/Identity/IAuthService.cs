using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.Application.Models.Identity;

namespace ArtExhibitionSystem.Application.Interfaces.Identity
{
    public interface IAuthService
    {
        Task<AuthRequest> Login(AuthRequest authRequest);
        Task<AuthRequest> Register(RegistrationRequest registrationRequest);
    }
}
