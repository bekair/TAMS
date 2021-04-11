using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TraineeAddress : AddressBase
    {
        [Required]
        [ForeignKey("Trainee")]
        public long TraineeId { get; set; }


        //Navigation Properties
        public Trainee Trainee { get; set; }
    }
}
