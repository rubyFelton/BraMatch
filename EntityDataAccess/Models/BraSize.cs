using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDataAccess.Models
{
    public class BraSize
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string MesureSystem { get; set; }
        public string CupSize { get; set; }
        public string BandSize { get; set; }
        public string OtherSize { get; set; }
    }
}
