﻿using System;
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
        public TennisCoach TennisCoach { get; set; }
        public TennisCourt TennisCourt { get; set; }
        public TennisCourtSchedule TennisCourtSchedule { get; set; }
        public TennisTrainingPackage TennisTrainingPackage { get; set; }
        public ICollection<TennisTrainee> TennisTraineeList { get; set; }
    }
}
