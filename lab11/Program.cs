/* lab 11
 Scrieti un program care va modela statii de pompare.

O statie de pompare poate pune la dispozitia clientilor mai multe tipuri de combustibil

• Benzina
• Diesel
• GPL
• Electricitate

Autovehiculele

Autovehiculele sunt caracterizate de model, id si o metoda ce va produce descrierea completa a
autovehiculului. Ele pot fi de mai multe tipuri

• Benzina - capabile sa fie alimentate doar cu benzina
• Diesel - capabile sa fie alimentate doar cu diesel
• GPL - capabile sa fie alimentate atat cu benzina cat si cu GPL
• Electrice - capabile sa fie alimentate doar cu electricitate
• Plug-in hybrid- capabile sa fie alimentate atat cu benzina cat si cu electricitate

Statiile de pompare

Statiile de pompare sunt de mai multe tipuri

• Clasice
    o Pot alimenta doar Benzina, Diesel si GPL
• Hibride
    o Pot alimenta toate tipurile de combustibil

Statiile de pompare vor detine mai multe metode specifice fiecarui tip de combustibil suportat.
Metodele vor simula alimentarea unui autovehicul cu un combustibilul specific.
Aceste metode vor primi ca parametru atat autovehiculul cat si cantitatea de combustibil dorita.
Apelul metodelor va afisa pe ecran descrierea completa a autovehiculului si cantitatea alimentata.
Statiile de pompare vor avea o cantitate infinita de combustibil.

Instantiati statii de pompare, creați auovehicule si alimentati-le la statiile de pompare instantiate.

Suplimentar
Un camion este un autovehicul caracterizat de un cap tractor si o cisterna. Capul tractor este un
autovehicul diesel.

Cisterna

Incarcarea

• Cisterna poate fi incarcata cu oricare dintre combustibilii clasici nepresurizati (benzina, diesel).
Aceasta va memora atat cantitatea de combustibil incarcata cat si tipul acestuia.
• Daca se va incerca alimentarea cisternei cu un alt tip de combustibil decat cel gata incarcat, atunci
aceasta va refuza incarcarea, si va afisa un mesaj corespunzator.

Alimentarea

• Asemenea unei statii de incarcare clasice, cisterna va putea alimenta orice autovehicul compatibil.
• La alimentarea unui autovehicul, cisterna va tine cont de tipul combustibilului precum si de
cantitatea existenta.
• Metoda va afisa mesajele corespunzatoare.

Instantiati camionul, alimentati-l, incarcati-i cisterna. Alimentati autovehicule folosind cisterna. Alimentati
camionul folosind propria cisterna.
*/

using lab11;
using lab11.Autovehicule;
using lab11.Camion;
using lab11.Statii_De_Pompare;

// Rezolvare Pt I
// Instantiati statii de pompare, creați auovehicule si alimentati-le la statiile de pompare instantiate.

// Instantierea statiilor de pompare
StatieDePompareHibrida statieDePompareHibrida = new StatieDePompareHibrida();

StatieDePompareClasica statieDePompareClasica = new StatieDePompareClasica();

// Instantierea autovehiculelor
Autovehicul autoBenzina = new AutovehiculBenzina("A100", 1);
Autovehicul autoDiesel = new AutovehiculDiesel("AC2022", 2);
Autovehicul autoGPL = new AutovehiculGPL("Alpha 1000", 10);
Autovehicul autoElectric = new AutovehiculElectric("X", 20);
Autovehicul autoHybrid = new AutovehiculPlugInHybrid("XS 4100", 30);

// Alimentari
statieDePompareClasica.AlimentareBenzina(autoBenzina, 200);

statieDePompareClasica.AlimentareBenzina(autoElectric, 100);

statieDePompareClasica.AlimentareBenzina(autoGPL, 500);
statieDePompareClasica.AlimentareGPL(autoGPL, 500);

statieDePompareHibrida.AlimentareDiesel(autoDiesel, 700);

// Rezolvare Pt II
// Instantiati camionul, alimentati-l, incarcati-i cisterna. Alimentati autovehicule folosind cisterna. Alimentati
//camionul folosind propria cisterna.

Camion camion = new Camion("4000", 9, TipCombustibil.Benzina);

statieDePompareHibrida.AlimentareBenzina(camion.cisterna, 5000);

camion.cisterna.AlimentareDiesel(camion.capTractor, 200);

camion.cisterna.AlimentareDiesel(autoDiesel, 200);