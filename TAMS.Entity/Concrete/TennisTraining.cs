﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Common.Enums;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TennisTraining : EntityBase
    {
        [Required]
        [ForeignKey("Coach")]
        public long CoachId { get; set; }

        [ForeignKey("TennisTrainingPackage")]
        public long? TennisTrainingPackageId { get; set; }
        
        [Required]
        [ForeignKey("TennisCourt")]
        public long TennisCourtId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public TrainingStatus TrainingStatus { get; set; }


        //Navigation Properties
        public Coach Coach { get; set; }
        public TennisTrainingPackage TennisTrainingPackage { get; set; }
        public TennisCourt TennisCourt { get; set; }
        public ICollection<Trainee> TraineeList { get; set; }
    }
}
