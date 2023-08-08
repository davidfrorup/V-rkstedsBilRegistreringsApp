using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedsBilRegistreringsApp.Kode;

[UlovligKøretøj(Mærke = "Genesis", Model = "GV80")]
internal class Køretøj<T>
{

    private const int _førsteGangsSyn = 5;

    private const int _intervalSyn = 2;


    public string? Mærke { get; set; }

    public string? Model { get; set; }

    public T? Størrelse { get; set; }

    public record KundeKontaktInfoRecord(string? kundensFornavn, string? kundensEfternavn, string? kundensTlf);
    public KundeKontaktInfoRecord KundeKontaktInfo { get; set; }

    //public string? Mærke { get; set; }
    //public string? Model { get; set; }
   // public T Størrelse { get; set; }



    public Køretøj(string? mærke, string? model, T størrelse, string? kundensFornavn, string? kundensEfternavn, string? kundensTlf)
    {
        Mærke = mærke;
        Model = model;
        Størrelse = størrelse;

        KundeKontaktInfo = new KundeKontaktInfoRecord(kundensFornavn, kundensEfternavn, kundensTlf);
    }


    [UlovligKøretøj(Mærke = "Toyota", Model = "Yaris")]



    public string GetAllKøretøjInfo()
    {
        return $"Mærke {Mærke}, Model: {Model}, Størrelse: {Størrelse}";
    }
}
