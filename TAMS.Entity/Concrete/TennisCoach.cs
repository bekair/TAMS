﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TennisCoach : EntityBase
    {
        [Required]
        [ForeignKey("AppUser")]
        public long AppUserId { get; set; }

        public int? YearsOfExperience { get; set; }


        //Navigation Properties
        public AppUser AppUser { get; set; }
        public ICollection<TennisTrainee> TennisTraineeList { get; set; }
        public ICollection<TennisTraining> TennisTrainingList { get; set; }
    }
}