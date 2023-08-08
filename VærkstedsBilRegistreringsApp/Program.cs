using System.Reflection;
using VærkstedsBilRegistreringsApp.Kode.Enum;

Console.Clear();

Person p = new();
Person.Alder = 50;
Person p2 = new("Niels", "Olesen");


Console.WriteLine($"{p.SayHello}");
Console.WriteLine($"{p2.SayHello}");
//Console.WriteLine($"Mit bilmærke er: {p2.MinBil.Mærke} \nMin alder: {Person.Alder}");

Køretøj<double> bil = new("Audi", "A6", 3.5);
Console.WriteLine($"Bilinfo: {bil.GetAllKøretøjInfo()}");

var minBilType = bil.GetType().GetCustomAttributes().OfType<Ulovligkøretøj>().FirstOrDefault();

MethodBase? GetAllKøretøjInfoMethod = bil.GetType().GetMethod("GetAllKøretøjInfo");
var myMethodAttribute = GetAllKøretøjInfoMethod.GetCustomAttributes().OfType<Ulovligkøretøj>().FirstOrDefault();

Console.WriteLine($"Bil ulovlig bil info (class level): {minBilType.Mærke} {minBilType.Model}");
Console.WriteLine($"Bil ulovlig bil info (method level): {myMethodAttribute.Mærke} {myMethodAttribute.Model}");

TilbagekaldteBiler($"TilbagekaldteBiler AlfaRomeo)
