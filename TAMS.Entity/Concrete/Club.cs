using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class Club : EntityBase
    {
        [ForeignKey("Academy")]
        public long? AcademyId { get; set; }

        [Required]
        public string ClubName { get; set; }

        public string ClubAbbreviation { get; set; }

        public string ClubFounder { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }


        //Navigation Properties
        public Academy Academy { get; set; }
        public ICollection<TennisCourt> TennisCourtList { get; set; }
        public ICollection<Trainee> TraineeList { get; set; }
        public ClubAddress ClubAddress { get; set; }
    }
}