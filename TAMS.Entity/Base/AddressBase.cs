using System.ComponentModel.DataAnnotations;
using TAMS.Common.Enums;

namespace TAMS.Entity.Base
{
    public abstract class AddressBase : EntityBase
    {
        [Required]
        public AddressType AddressType { get; set; }

        [Required]
        public string AddressName { get; set; }

        [Required]
        public string AddressLine { get; set; }
    }
}