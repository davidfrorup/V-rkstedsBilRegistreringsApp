using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedsBilRegistreringsApp.Kode.Attributer;

internal class TilbagekaldteBilerAttributer : Attribute
{
    public string? Mærke { get; set; }
    public string? Model { get; set; }
    public string? Årgang { get; set; }
    public string? Fabriksfejl { get; set; }

}
