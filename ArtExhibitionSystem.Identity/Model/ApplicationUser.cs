using Microsoft.AspNetCore.Identity;

namespace ArtExhibitionSystem.Identity.Model
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
