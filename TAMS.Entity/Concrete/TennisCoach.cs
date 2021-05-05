using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Abstracts;

namespace TAMS.Entity.Concrete
{
    public class TennisCoach : EntityBase
    {
        [Required]
        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }

        [Required]
        [ForeignKey("Club")]
        public int ClubId { get; set; }

        public int? YearsOfExperience { get; set; }


        //Navigation Properties
        public virtual AppUser AppUser { get; set; }
        public virtual Club Club { get; set; }
        public virtual ICollection<TennisTrainee> TennisTraineeList { get; set; }
        public virtual ICollection<TennisTraining> TennisTrainingList { get; set; }
    }
}
