using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Abstracts;

namespace TAMS.Entity.Concrete
{
    public class TennisCourtSchedule : EntityBase
    {
        [Required]
        [ForeignKey("TennisCourt")]
        public int TennisCourtId { get; set; }

        [Required]
        [ForeignKey("TennisTraining")]
        public int TennisTrainingId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }


        //Navigation Properties
        public virtual TennisCourt TennisCourt { get; set; }
        public virtual TennisTraining TennisTraining { get; set; }
    }
}
