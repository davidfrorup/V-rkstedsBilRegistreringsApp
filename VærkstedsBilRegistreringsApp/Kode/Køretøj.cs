using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedsBilRegistreringsApp.Kode
{
    [Ulovligkøretøj(Mærke = "Genesis", Model = "GV80")]
    internal class Køretøj<T>
    {

        private const int _førsteGangsSyn = 5;

        private const int _intervalSyn = 2;


        public string? Mærke { get; set; }

        public string? Model { get; set; }

        public T? Størrelse { get; set; }

        

        public Køretøj(string? mærke, string? model, T størrelse)



            [Ulovligkøretøj(Mærke = "Toyota", Model = "Varis")]



        public string GetAllKøretøjInfo()
        {
            return $"Mærke {Mærke}, Model: {Model}, Størrelse: {Størrelse}";
        }
    }
}
