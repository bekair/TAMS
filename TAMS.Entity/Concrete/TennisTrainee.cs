using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Common.Enums;
using TAMS.Entity.Abstracts;

namespace TAMS.Entity.Concrete
{
    public class TennisTrainee : EntityBase
    {
        [Required]
        [ForeignKey("Club")]
        public int ClubId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Required]
        public TennisTraineeType TraineeType { get; set; }


        //Navigation Properties
        public virtual Club Club { get; set; }
        public virtual ICollection<TennisCoach> CoachList { get; set; }
        public virtual ICollection<TennisTraining> TennisTrainingList { get; set; }
        public virtual ICollection<TennisTrainingPackage> TennisTrainingPackage { get; set; }
        public virtual ICollection<TennisTraineeAddress> TennisTraineeAddressList { get; set; }
    }
}
