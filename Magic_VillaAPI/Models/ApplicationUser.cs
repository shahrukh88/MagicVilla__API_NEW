using Microsoft.AspNetCore.Identity;

namespace Magic_VillaAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
       public string Name { get; set; }
    }
}
 