// Ex 1
/*
 Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui
*/

Console.Write("Introduceti lungimea paralelipipedului: ");
int lungimeParalelipiped = int.Parse(Console.ReadLine());

Console.Write("Introduceti latimea paralelipipedului: ");
int latimeParalelipiped = int.Parse(Console.ReadLine());

Console.Write("Introduceti inaltimea paralelipipedului: ");
int inaltimeParalelipiped = int.Parse(Console.ReadLine());

int volumParalelipiped = lungimeParalelipiped * latimeParalelipiped * inaltimeParalelipiped;
Console.WriteLine("Volumul paralelipipedului este: " + volumParalelipiped);
