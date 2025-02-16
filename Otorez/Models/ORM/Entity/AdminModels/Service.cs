﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Otorez.Models.ORM.Entity.AdminModels
{
    [Table("Service")]
    public class Service
    {
        [Key]
        [Column(Order = 1)]
        public int ServiceID { get; set; }

        [Column(Order = 2)]
        [MaxLength(50)]
        public string ServiceType { get; set; }

        [MaxLength(50)]
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        [MaxLength(50)]
        public string Currency { get; set; }

        public int? AccountID { get; set; }

    }

}