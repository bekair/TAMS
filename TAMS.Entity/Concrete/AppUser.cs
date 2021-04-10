using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class AppUser : IdentityUser<long>, IEntity
    {
        public AppUser() : base()
        {
        }

        public AppUser(string userName) : base(userName)
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Properties
        public ICollection<Coach> CoachList { get; set; }
    }
}
