﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfosiShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string IPAddress { get; set; }
    }
}
