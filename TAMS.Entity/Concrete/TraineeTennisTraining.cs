using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TraineeTennisTraining:EntityBase
    {
        [Required]
        [ForeignKey("Trainee")]
        public long TraineeId { get; set; }

        [Required]
        [ForeignKey("TennisTraining")]
        public long TennisTrainingId { get; set; }


        //Navigation Properties
        public Trainee Trainee { get; set; }
        public TennisTraining TennisTraining { get; set; }
    }
}
