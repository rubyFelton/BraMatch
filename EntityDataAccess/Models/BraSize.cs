using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityDataAccess.Models
{
    public class BraSize
    {
        public int Id { get; set; }
        [Required]
        public string Region { get; set; }
        public string MeasureSystem { get; set; }
        [Required]
        public string CupSize { get; set; }
        [Required]
        public string BandSize { get; set; }
        public string OtherSize { get; set; }
    }
}
