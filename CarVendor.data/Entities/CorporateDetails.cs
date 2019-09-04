﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVendor.data.Entities
{
    public class CorporateDetails
    {
        [Key]
        public long Id { get; set; }
        public string CorporateName { get; set; }
        public string CorporateSite { get; set; }
        public int RegistrationNo { get; set; }

        [ForeignKey("Id")]
        public virtual User user { get; set; }
    }
}
