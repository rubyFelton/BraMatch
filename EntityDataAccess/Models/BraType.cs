using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityDataAccess.Models
{
    public class BraType
    {
        public int Id { get; set; }
        [Required]
        public string Cup { get; set; }
        public string Strap { get; set; }
        public bool Convertible { get; set; }
        [Required]
        public bool Wire { get; set; }
        public string Style { get; set; }
    }
}
