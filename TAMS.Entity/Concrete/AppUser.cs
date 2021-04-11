﻿using Microsoft.AspNetCore.Identity;
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
        public Coach Coach { get; set; }
    }
}
