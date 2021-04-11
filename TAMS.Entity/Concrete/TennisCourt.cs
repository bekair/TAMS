using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TAMS.Common.Enums;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TennisCourt : EntityBase
    {
        [Required]
        public long ClubId { get; set; }

        public string CourtName { get; set; }

        public string CourtNumber { get; set; }
        
        [Required]
        public CourtSurface CourtSurface { get; set; }

        [Required]
        public CourtType CourtType { get; set; }

        [Required]
        public bool IsHeatingExist { get; set; }

        [Required]
        public bool IsLightingExist { get; set; }


        //Navigation Properties
        public Club Club { get; set; }
        public ICollection<TennisCourtSchedule> TennisCourtScheduleList { get; set; }
    }
}