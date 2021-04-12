using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [ForeignKey("CreatedByUser")]
        public long CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("UpdatedByUser")]
        public long? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }


        //Navigation Properties
        public AppUser CreatedByUser { get; set; }
        public AppUser UpdatedByUser { get; set; }
        public ICollection<AppUser> CreatedUserList { get; set; }
        public ICollection<AppUser> UpdatedUserList { get; set; }
        public TennisCoach TennisCoach { get; set; }
    }
}
