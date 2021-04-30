﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAMS.Common.Enums;
using TAMS.Entity.Abstracts;
using TAMS.Entity.Interfaces;

namespace TAMS.Entity.Concrete
{
    public class TennisTraineeAddress : EntityBase, IAddress
    {
        [Required]
        [ForeignKey("TennisTrainee")]
        public int TennisTraineeId { get; set; }

        [Required]
        public AddressType AddressType { get; set; }

        [Required]
        public string AddressName { get; set; }

        [Required]
        public string AddressLine { get; set; }


        //Navigation Properties
        public TennisTrainee TennisTrainee { get; set; }
    }
}
