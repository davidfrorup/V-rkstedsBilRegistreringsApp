using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VærkstedsBilRegistreringsApp.Kode.Attribute;

namespace VærkstedsBilRegistreringsApp.Kode.Enum;

internal class TilbagekaldteBilerEnum
{
    [Display(Name = "Fiat Punto")]
    FiatPunto,
        [Display(Name = "Alfa Romeo")]
    AlfaRomeo

}
