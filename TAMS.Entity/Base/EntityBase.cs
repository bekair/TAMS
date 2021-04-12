using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Concrete;

namespace TAMS.Entity.Base
{
    public abstract class EntityBase : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [ForeignKey("CreatedByUser")]
        public long CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("UpdatedByUser")]
        public long? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        //Navigation Properties
        public AppUser CreatedByUser { get; set; }
        public AppUser UpdatedByUser { get; set; }
    }
}
