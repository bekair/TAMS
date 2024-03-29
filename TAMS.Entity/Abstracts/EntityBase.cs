﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Entity.Concrete;
using TAMS.Entity.Interfaces;

namespace TAMS.Entity.Abstracts
{
    public abstract class EntityBase : IKey, IGenericInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [ForeignKey("CreatedByUser")]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("UpdatedByUser")]
        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        //Navigation Properties
        public AppUser CreatedByUser { get; set; }
        public AppUser UpdatedByUser { get; set; }
    }
}
