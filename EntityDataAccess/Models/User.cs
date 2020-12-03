using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityDataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
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
