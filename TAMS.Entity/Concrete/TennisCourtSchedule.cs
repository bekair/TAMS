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
        public TennisCourt TennisCourt { get; set; }
        public TennisTraining TennisTraining { get; set; }
    }
}
