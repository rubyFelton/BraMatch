using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDataAccess.Models
{
    public class BraType
    {
        public int Id { get; set; }
        public string Cup { get; set; }
        public string Strap { get; set; }
        public bool Convertable { get; set; }
        public bool Wire { get; set; }
        public string Style { get; set; }
    }
}
