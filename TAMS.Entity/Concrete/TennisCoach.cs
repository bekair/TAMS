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

        public int? YearsOfExperience { get; set; }


        //Navigation Properties
        public AppUser AppUser { get; set; }
        public ICollection<TennisTrainee> TennisTraineeList { get; set; }
        public ICollection<TennisTraining> TennisTrainingList { get; set; }
    }
}
