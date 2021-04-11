using System.Collections.Generic;
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

        [Required]
        public bool IsPaymentCompleted { get; set; }


        //Navigation Properties
        public Trainee Trainee { get; set; }
        public ICollection<TennisTraining> TennisTrainingList { get; set; }
    }
}