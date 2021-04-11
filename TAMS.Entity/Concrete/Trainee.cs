using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class Trainee : EntityBase
    {
        [Required]
        [ForeignKey("Club")]
        public long ClubId { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }


        //Navigation Properties
        public Club Club { get; set; }
        public ICollection<TraineeAddress> TraineeAddressList { get; set; }
        public ICollection<Coach> CoachList { get; set; }
        public ICollection<TennisTraining> TennisTrainingList { get; set; }
        public ICollection<TennisTrainingPackage> TennisTrainingPackageList { get; set; }
    }
}
