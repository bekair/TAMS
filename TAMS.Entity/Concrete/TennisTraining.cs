using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Common.Enums;
using TAMS.Entity.Abstracts;

namespace TAMS.Entity.Concrete
{
    public class TennisTraining : EntityBase
    {
        [ForeignKey("TennisTrainingPackage")]
        public int? TennisTrainingPackageId { get; set; }
        
        [Required]
        [ForeignKey("TennisCoach")]
        public int TennisCoachId { get; set; }

        [Required]
        [ForeignKey("TennisCourt")]
        public int TennisCourtId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public TrainingStatus TrainingStatus { get; set; }


        //Navigation Properties
        public virtual TennisCoach TennisCoach { get; set; }
        public virtual TennisCourt TennisCourt { get; set; }
        public virtual TennisCourtSchedule TennisCourtSchedule { get; set; }
        public virtual TennisTrainingPackage TennisTrainingPackage { get; set; }
        public virtual ICollection<TennisTrainee> TennisTraineeList { get; set; }
    }
}
