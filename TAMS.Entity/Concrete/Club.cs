using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Abstracts;

namespace TAMS.Entity.Concrete
{
    public class Club : EntityBase
    {
        [ForeignKey("Academy")]
        public int? AcademyId { get; set; }

        [Required]
        public string ClubName { get; set; }

        public string ClubAbbreviation { get; set; }

        public string ClubFounder { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }


        //Navigation Properties
        public virtual Academy Academy { get; set; }
        public virtual ICollection<TennisCourt> TennisCourtList { get; set; }
        public virtual ICollection<TennisTrainee> TennisTraineeList { get; set; }
        public virtual ClubAddress ClubAddress { get; set; }
    }
}