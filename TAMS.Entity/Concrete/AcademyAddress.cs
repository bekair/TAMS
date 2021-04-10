using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class AcademyAddress : AddressBase
    {
        [Required]
        [ForeignKey("Academy")]
        public long AcademyId { get; set; }


        //Navigation Properties
        public Academy Academy { get; set; }
    }
}
