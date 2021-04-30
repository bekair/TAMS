using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Common.Enums;
using TAMS.Entity.Interfaces;

namespace TAMS.Entity.Concrete
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser() : base()
        {
        }

        public AppUser(string userName) : base(userName)
        {
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [ForeignKey("CreatedByUser")]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("UpdatedByUser")]
        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }


        //Navigation Properties
        public virtual AppUser CreatedByUser { get; set; }
        public virtual AppUser UpdatedByUser { get; set; }
        public virtual ICollection<AppUser> CreatedUserList { get; set; }
        public virtual ICollection<AppUser> UpdatedUserList { get; set; }
        public virtual TennisCoach TennisCoach { get; set; }
    }
}
