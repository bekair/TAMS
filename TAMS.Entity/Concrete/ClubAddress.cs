using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class ClubAddress : AddressBase
    {
        [Required]
        [ForeignKey("Club")]
        public long ClubId { get; set; }


        //Navigation Properties
        public Club Club { get; set; }
    }
}