//Lab 8

using lab8;

Tren tren = new Tren("Arnold");

VagonPtPers vagonPers1 = new VagonPtPers(500, 2020, 20);
VagonPtPers vagonPers2 = new VagonPtPers(500, 2020, 20);

tren.AdaugaVagonPtPers(vagonPers1);
tren.AdaugaVagonPtPers(vagonPers2);

VagonClasaI vagonClsI1 = new VagonClasaI(500, 2023, 10);
VagonClasaI vagonClsI2 = new VagonClasaI(500, 2023, 10);

tren.AdaugaVagonClasaI(vagonClsI1);
tren.AdaugaVagonClasaI(vagonClsI2);

VagonDeMarfa marfar1 = new VagonDeMarfa(500, 2000, 1000, TipMarfa.carbuni);
VagonDeMarfa marfar2 = new VagonDeMarfa(500, 2010, 1500, TipMarfa.carbuni);

tren.AdaugaVagonDeMarfa(marfar1);
tren.AdaugaVagonDeMarfa(marfar2);

VagonDeMarfa marfar3 = new VagonDeMarfa(500, 2020, 800, TipMarfa.cereale);
VagonDeMarfa marfar4 = new VagonDeMarfa(500, 2007, 900, TipMarfa.cereale);

tren.AdaugaVagonDeMarfa(marfar3);
tren.AdaugaVagonDeMarfa(marfar4);

VagonDeMarfa marfar5 = new VagonDeMarfa(500, 2020, 2000, TipMarfa.otel);
VagonDeMarfa marfar6 = new VagonDeMarfa(500, 2007, 1900, TipMarfa.otel);

tren.AdaugaVagonDeMarfa(marfar5);
tren.AdaugaVagonDeMarfa(marfar6);

List<int> sumarMarfa = tren.SumarMarfa();

Console.WriteLine("Sumar Marfa:");
foreach(int sumar in sumarMarfa)
{
    Console.WriteLine(sumar);
}
Console.WriteLine();

Console.WriteLine("Numar total locuri in tren: " + tren.NumarDeLocuri());
Console.WriteLine();

tren.PleacaDinGara();
Console.WriteLine();

tren.OpresteInGara();
Console.WriteLine();