/* Lab 10

Scrieti un program care va modela operatiunile unei casa de marcat.

Casa de marcat

O casa de marcat va avea o metoda prin care va scana un produs, va oferi metode de plata cash sau prin
intermediul unui POS.

• In cazul platii cash, casa de marcat

1. va deschide un seif
2. va introduce suma in seif
3. va inchide seif-ul
4. Va elibera chitanta

Aceasta functionalitate va fi modelata printr-o metoda care va primi un singur parametru, suma
de plata. La fiecare dintre operatiunile de mai sus, un mesaj corespunzator va fi afisat pe ecran

• In cazul platii cu cardul, casa de marcat va pune la dispozitia clientului un POS, printr-o metoda care
va oferi la cerere un POS

POS-ul

POS-ul va accepta atat plata contactless cat si plata contact-full. Cele doua modalitati de plata vor fi
modelate prin intermediul a doua metode, ce vor primi doi parametri: suma si dispozitivul prin care se
va efectua plata „ascuns” sub o interfata specifica fiecarui mod de plata.

Pentru plata prin intermediul POS-ului, clientul va putea folosi atat

 carduri clasice – suporta doar plati contactfull
 carduri contactless - suporta atat plati contact-full cat si plati contactless
 telefoane mobile contactless - suporta doar plati contactless

Descrierea interfetelor

Plata contact-full implica urmatoarele operatiuni:

 IntroduCard
 EfectueazaPlata
 ExtrageCard

Plata contactless implica urmatoarele operatiuni:

 ApropieCard
 EfectueazaPlata

Instantiati casa, carduri, telefoane, efectuati plati.
*/

using lab10;
using lab10.Dispozitive;


CasaDeMarcat casaDeMarcat = new CasaDeMarcat();

Dispozitiv telefon = new Telefon();

telefon.AdaugaBani(500);

casaDeMarcat.dispozitiv = telefon;

casaDeMarcat.ScanareProdus();

Console.WriteLine();

Dispozitiv card1 = new CardClasic();

card1.AdaugaBani(6000);

casaDeMarcat.dispozitiv = card1;

casaDeMarcat.ScanareProdus();

Console.WriteLine();

Dispozitiv card2 = new CardContactless();

card2.AdaugaBani(7000);

casaDeMarcat.dispozitiv = card2;

casaDeMarcat.ScanareProdus();