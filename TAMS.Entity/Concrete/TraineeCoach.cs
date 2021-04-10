using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class TraineeCoach : EntityBase
    {
        [Required]
        [ForeignKey("Trainee")]
        public long TraineeId { get; set; }

        [Required]
        [ForeignKey("Coach")]
        public long CoachId { get; set; }

        //Navigation Properties
        public Trainee Trainee { get; set; }
        public AppUser Coach { get; set; }
    }
}
