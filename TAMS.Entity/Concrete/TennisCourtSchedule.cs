using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TennisCourtSchedule:EntityBase
    {
        [Required]
        [ForeignKey("TennisCourt")]
        public long TennisCourtId { get; set; }

        [Required]
        [ForeignKey("TennisTraining")]
        public long TennisTrainingId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }


        //Navigation Properties
        public TennisCourt TennisCourt { get; set; }
        public TennisTraining TennisTraining { get; set; }
    }
}
