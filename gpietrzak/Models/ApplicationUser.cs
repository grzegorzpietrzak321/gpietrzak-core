using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using gpietrzak.Models.Blog;

namespace gpietrzak.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Article> Articles { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
