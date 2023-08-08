using System.ComponentModel.DataAnnotations;
using System.Reflection;
using VærkstedsBilRegistreringsApp.Kode;
using VærkstedsBilRegistreringsApp.Kode.Attributer;
using VærkstedsBilRegistreringsApp.Kode.Enum;

Console.Clear();

Person p = new();
Person.Alder = 50;
Person p2 = new("Niels", "Olesen");


Console.WriteLine($"{p.SayHello()}");
Console.WriteLine($"{p2.SayHello()}");

Køretøj<double> bil = new("Audi", "A6", 3.5);
Console.WriteLine($"Bilinfo: {bil.GetAllKøretøjInfo()}");

var minBilType = bil.GetType().GetCustomAttributes().OfType<UlovligKøretøj>().FirstOrDefault();

MethodBase? getAllKøretøjInfoMethod = bil.GetType().GetMethod("GetAllKøretøjInfo");
var myMethodAttribute = getAllKøretøjInfoMethod.GetCustomAttributes().OfType<UlovligKøretøj>().FirstOrDefault();

Console.WriteLine($"Bil ulovlig bil info (class level): {minBilType.Mærke} {minBilType.Model}");
Console.WriteLine($"Bil ulovlig bil info (method level): {myMethodAttribute.Mærke} {myMethodAttribute.Model}");

TilbagekaldteBilerEnum tilbageKaldteBilerEnum = p2.TjekForTilbagekaldteBiler(TilbagekaldteBilerEnum.AlfaRomeo);


MemberInfo[] memberInfo = tilbageKaldteBilerEnum.GetType().GetMember(tilbageKaldteBilerEnum.ToString());
TilbagekaldteBilerAttributer? selectedAttribute = memberInfo.First().GetCustomAttribute<TilbagekaldteBilerAttributer>();
if (selectedAttribute != null)
{
    Console.WriteLine($"Valg af tilbagekaldte bil er: {selectedAttribute.Mærke} {selectedAttribute.Model}, Fabriksfejl: {selectedAttribute.Fabriksfejl}");
}
