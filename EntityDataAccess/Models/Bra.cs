using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityDataAccess.Models
{
    public class Bra
    {
        public int Id { get; set; }
        [Required]
        public BraSize Size { get; set; }
        public BraType Type { get; set; }
        [Required]
        [MaxLength(200)]
        public string Maker { get; set; }
        [Required]
        [MaxLength(200)]
        public string Model { get; set; }
    }
}
