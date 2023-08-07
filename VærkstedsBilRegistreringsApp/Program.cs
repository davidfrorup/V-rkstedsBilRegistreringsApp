




Person p = new();
Person.Alder = 50;
Person p2 = new("Niels", "Olesen");


Console.WriteLine($"{p.SayHello}");
Console.WriteLine($"{p2.SayHello}");
Console.WriteLine($"Mit bilmærke er: {p2.MinBil.Mærke} \nMin alder: {Person.Alder}");
