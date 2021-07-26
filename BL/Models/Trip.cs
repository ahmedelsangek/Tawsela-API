﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Trip
    {
        public int Id { get; set; }

        [Required]
        public string CaptainId { get; set; }

        [Required]
        public string LocationFrom { get; set; }

        [Required]
        public string LocationTo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DepartureDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string ArrivalDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime DepartialTime { get; set; }


        [InverseProperty("Driver")]
        [ForeignKey("CaptainId")]
        public virtual ApplicationUser Captain { get; set; }
        [InverseProperty("Passenger")]
        [ForeignKey("ClientNumber")]
        public virtual ICollection<ApplicationUser> Clients { get; set; }

    }
}