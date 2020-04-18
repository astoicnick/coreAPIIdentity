using Microsoft.AspNetCore.Identity;

namespace Data
{
    public class WholeAppUser : IdentityUser
    {
        public int Virtue { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int WisdomCount { get; set; }
    }
}