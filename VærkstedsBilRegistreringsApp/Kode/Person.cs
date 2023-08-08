using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VærkstedsBilRegistreringsApp.Kode.Enum;

namespace VærkstedsBilRegistreringsApp.Kode;

internal class Person
{

    public TilbagekaldteBilerEnum TilbagekaldteBiler { get; set; }
    public static int Alder { get; set; }

    public string? Fornavn { get; set; }
    
    public string? Efternavn { get; set; }

    private bool _visnavn { get; set; }

    public Person()
    {

        _visnavn = false;

        

    }

        public Person(string? forNavn, string? efterNavn)
    {
        _visnavn = true;
        Fornavn = forNavn;
        Efternavn = efterNavn;
        Køretøj<double> MinBil = new("Audi", "A6", 3.5);
     
        Køretøj<string> MinCykel = new("Audi", "A6", "20cm - 50cm");
      

    }

    public string SayHello()
    {

        if (_visnavn == false)
            return $"Hello {Fornavn} {Efternavn}!";

        else
            return "Intet navn givet!";
    }

    public TilbagekaldteBilerEnum TjekForTilbagekaldteBiler(TilbagekaldteBilerEnum tilbagekaldteBiler)
    {
        return tilbagekaldteBiler;
    }

}
