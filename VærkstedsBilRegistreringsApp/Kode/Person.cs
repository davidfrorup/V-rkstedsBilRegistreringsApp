using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedsBilRegistreringsApp.Kode
{
   public class Person
    {
        public static int Alder { get; set; }

        public Køretøj? MinBil { get; set; }

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
            MinBil = new();
            MinBil.Mærke = "Audi";
        }

        public string SayHello()
        {

            if (_visnavn == false)
                return $"Hello {Fornavn} {Efternavn}!";

            else
                return "Intet navn givet!";
        }

    }
}
