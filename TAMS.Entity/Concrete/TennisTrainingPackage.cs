using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Common.Enums;
using TAMS.Entity.Abstracts;

namespace TAMS.Entity.Concrete
{
    public class TennisTrainingPackage : EntityBase
    {
        [Required]
        [ForeignKey("TennisTrainee")]
        public int TennisTraineeId { get; set; }

        [Required]
        [ForeignKey("TennisTrainingPackageInformation")]
        public int TennisTrainingPackageInformationId { get; set; }

        [Required]
        public int TotalNumberOfTraining { get; set; }

        [Required]
        public int NumberOfRemainingTraining { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public PaymentStatus PaymentStatus { get; set; }


        //Navigation Properties
        public virtual ICollection<TennisTraining> TennisTrainingList { get; set; }
        public virtual TennisTrainee TennisTrainee { get; set; }
        public virtual TennisTrainingPackageInformation TennisTrainingPackageInformation { get; set; }
    }
}