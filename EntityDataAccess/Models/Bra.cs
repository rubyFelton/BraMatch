using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDataAccess.Models
{
    public class Bra
    {
        public int Id { get; set; }
        public BraSize Size { get; set; }
        public BraType Type { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
    }
}
