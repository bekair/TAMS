using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TAMS.Entity.Abstracts;

namespace TAMS.Entity.Concrete
{
    public class Academy : EntityBase
    {
        [Required]
        public string AcademyName { get; set; }

        public string AcademyFounder { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }


        //Navigation Properties
        public ICollection<Club> ClubList { get; set; }
        public AcademyAddress AcademyAddress { get; set; }
    }
}