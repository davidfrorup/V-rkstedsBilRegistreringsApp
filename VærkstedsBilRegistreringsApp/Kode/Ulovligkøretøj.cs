﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedsBilRegistreringsApp.Kode;

internal class UlovligKøretøj : Attribute
{
    public string? Mærke { get; set; }

    public string? Model { get; set; }

}
