using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TAMS.Common.Enums;
using TAMS.Entity.Abstracts;

namespace TAMS.Entity.Concrete
{
    public class TennisTrainingPackageInformation : EntityBase
    {
        [Required]
        public TennisTrainingType TennisTrainingType { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }


        //Navigation Properties
        public virtual ICollection<TennisTrainingPackage> TennisTrainingPackageList { get; set; }
    }
}