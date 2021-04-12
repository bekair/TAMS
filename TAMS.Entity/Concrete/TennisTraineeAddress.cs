using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TennisTraineeAddress : AddressBase
    {
        [Required]
        [ForeignKey("TennisTrainee")]
        public long TennisTraineeId { get; set; }


        //Navigation Properties
        public TennisTrainee TennisTrainee { get; set; }
    }
}
