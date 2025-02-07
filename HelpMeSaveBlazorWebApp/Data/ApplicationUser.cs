using Microsoft.AspNetCore.Identity;

namespace HelpMeSaveBlazorWebApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? Nickname { get; set; }

    }
}
