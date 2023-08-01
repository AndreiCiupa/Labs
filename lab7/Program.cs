using lab7;

Motor motorMasina1 = new Motor(61, 168, "diesel");
Autoturism masina1 = new Autoturism("BMW", "320d", 2007, motorMasina1, 4);

Console.WriteLine("Numarul autoturismelor create: " + Autoturism.GetNrAutoturismeCreate());
Console.WriteLine("Primul autoturism: " + Autoturism.GetAutoturismPutereMaxima().GetDescription());
Console.WriteLine();

masina1.PornesteMasina();
masina1.OpresteMasina();
Console.WriteLine();

Motor motorMasina2 = new Motor(50, 272, "benzina");
Autoturism masina2 = new Autoturism("Volkswagen", "polo VI", 2018, motorMasina2, 4);


Console.WriteLine("Numarul autoturismelor create: " + Autoturism.GetNrAutoturismeCreate());
Console.WriteLine("Al doilea autoturism: " + Autoturism.GetAutoturismPutereMaxima().GetDescription());
Console.WriteLine();

masina2.PornesteMasina();
masina2.OpresteMasina();
Console.WriteLine();