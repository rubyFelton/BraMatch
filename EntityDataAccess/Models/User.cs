using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityDataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(320)]
        public string Email { get; set; }
        [MaxLength(200)]
        public string DisplayName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Region { get; set; }
        public string MeasureSystem { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal BandMeasure { get; set; }
        [Column(TypeName = "decimal(5,2)")] 
        public decimal WidestMeasure { get; set; }
        [Column(TypeName = "decimal(5,2)")] 
        public decimal PointMeasure { get; set; }
        public bool Implants { get; set; }
        public bool Reduction { get; set; }
        public List<Bra> Bras { get; set; }
    }
}
