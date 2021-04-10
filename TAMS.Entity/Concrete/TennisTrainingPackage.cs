using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TennisTrainingPackage : EntityBase
    {
        [Required]
        [ForeignKey("Trainee")]
        public long TraineeId { get; set; }

        [Required]
        public int TotalTrainingNumber { get; set; }

        [Required]
        public int RemainingTrainingNumber { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }


        //Navigation Properties
        public Trainee Trainee { get; set; }
    }
}