using System;
using TAMS.Entity.Concrete;

namespace TAMS.Entity.Interfaces
{
    public interface IGeneralInfo
    {
        bool IsActive { get; set; }
        int CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        int? UpdatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }


        //Navigation Properties
        AppUser CreatedByUser { get; set; }
        AppUser UpdatedByUser { get; set; }
    }
}
