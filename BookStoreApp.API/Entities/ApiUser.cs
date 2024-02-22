using Microsoft.AspNetCore.Identity;

namespace BookStoreApp.API.Entities
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}