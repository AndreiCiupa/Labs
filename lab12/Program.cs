// Lab 12
/*
 Scrieti o clasa care va implementa o structura de date generica de tipul coada. (queue)

Coada va functiona pe principiul FIFO (first in first out) si va avea urmatoarele metode si proprietati:

• Enqueue – va adauga un element la capatul cozii
• Dequeue – va extrage primul element din coada si il va returna ca rezultat
• Count – va returna numarul de elemente din coada.

La initializarea cozii va fi stabilita capacitatea maxima a cozii.

In interiorul clasei, folositi o structura de tip vector pentru a stoca datele.

Initializati mai multe cozi (intregi, obiecte), adaugati elemente, extrageti elemente, afisati-le.
 */


using lab12;

MyQueue<string> raseDePisici = new MyQueue<string>(4);


Console.WriteLine("count: "+raseDePisici.Count());

raseDePisici.Enqueue("siameza");
raseDePisici.Enqueue("british shorthair");
raseDePisici.Enqueue("persana");
raseDePisici.Enqueue("sfinx");
raseDePisici.Enqueue("devon");

Console.WriteLine("count: " + raseDePisici.Count());

Console.WriteLine("out: " + raseDePisici.Dequeue());
raseDePisici.Enqueue("devon");

Console.WriteLine("count: " + raseDePisici.Count());

//raseDePisici.Afisare();

Console.WriteLine();

MyQueue<int> sirDeNumere = new MyQueue<int>(10);

sirDeNumere.Enqueue(1);
sirDeNumere.Enqueue(2);
sirDeNumere.Enqueue(3);
sirDeNumere.Enqueue(4);
sirDeNumere.Enqueue(5);
sirDeNumere.Enqueue(6);
sirDeNumere.Enqueue(7);
sirDeNumere.Enqueue(8);
sirDeNumere.Enqueue(9);
sirDeNumere.Enqueue(10);
sirDeNumere.Enqueue(11);

Console.WriteLine("count: " + sirDeNumere.Count());

Console.WriteLine("out: " + sirDeNumere.Dequeue());

Console.WriteLine("count: " + sirDeNumere.Count());