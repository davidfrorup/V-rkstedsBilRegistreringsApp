using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VærkstedsBilRegistreringsApp.Kode.Attributer;

namespace VærkstedsBilRegistreringsApp.Kode.Enum;

internal enum TilbagekaldteBilerEnum
{
    [TilbagekaldteBilerAttributer(Mærke = "Fiat", Model = "Punto", Årgang = "01-01-2010", Fabriksfejl = "Udstødning")]
    FiatPunto,
    [TilbagekaldteBilerAttributer(Mærke = "Alfa", Model = "Romeo", Årgang = "01-08-2019", Fabriksfejl = "Styrtøjet")]
    AlfaRomeo

}
