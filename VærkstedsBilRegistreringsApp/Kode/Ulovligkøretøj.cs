using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedsBilRegistreringsApp.Kode
{
    public class Ulovligkøretøj : Attribute
    {
        public string? Mærke { get; set; }

        public string? Model { get; set; }

       // public int Årgang { get; set; }
    }
}
