// Lab 9

using lab9;

ContBancar contBancar = new ContBancar("Marius Verde", 0);

Console.WriteLine(contBancar.GetDescription());

contBancar.DepunereBani(300);
contBancar.ExtragereBani(500);
contBancar.ExtragereBani(200);

Console.WriteLine(contBancar.GetDescription());

Console.WriteLine();


ContCurent contCurent = new ContCurent("Ana Macarie", 0);

Console.WriteLine(contCurent.GetDescription());

contCurent.DepunereBani(1200);
contCurent.ExtragereBani(1300);
contCurent.ExtragereBani(5300);

Console.WriteLine(contCurent.GetDescription());

Console.WriteLine();


ContDeEconomii contDeEconomii = new ContDeEconomii("Mihai Barabas", 150, 5);

Console.WriteLine(contDeEconomii.GetDescription());

contDeEconomii.DepunereBani(1500);

Console.WriteLine(contDeEconomii.GetDescription());

Console.WriteLine();


ContDeInvestitii contDeInvestitii = new ContDeInvestitii("Andreea Circe", 0, 10, 31);

Console.WriteLine(contDeInvestitii.GetDescription());

contDeInvestitii.DepunereBani(3555);
contDeInvestitii.ExtragereBani(2000);

Console.WriteLine(contDeInvestitii.GetDescription());

Console.WriteLine();
