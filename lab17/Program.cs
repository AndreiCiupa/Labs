// LABORATOR 17

/*
 • Un produs este caracterizat de
    • Id (unic)
    • Nume : string
    • Stoc: int
    • Producator
    • Categorie
    • Eticheta

• O categorie va fi caracterizata de:
    • Id (unic)
    • Nume : string
    • Pictograma – sub forma unui sir de
    caractere reprezentand url-ul imaginii
    corespunzatoare
    • NavigationProperty / FK- ce lipseste?

 • Eticheta este caracterizata de :
    • Id(unic)
    • Cod de bare (sub forma unui Guid)
    • Pret : double
    • NavigationProperty / FK- ce lipseste?

• Producatorii vor fi caracterizati de
    • Id(unic)
    • Nume
    • Adresa : string
    • CUI : string
    • NavigationProperty- ce lipseste?
 */

/*
1. Stabiliti relatiile dintre clase

2. Realizati diagrama uml

3. Stabiliti relatiile dintre entitati (1-
1,1-*,*-*)

4. Stabiliti Navigation Property-urile si
FK-urile necesare

5. Creeati DB-ul, DBContext-ul, precum
si o functie statica seedDB/resetDB
*/

/*
• Scrieti urmatoarele functii
    • Adaugare de categorie
    • Adaugare de producator
    • Modificarea pretului unui produs
    • Obtinerea valorii totale a stocului
    magazinului
    • Obtinearea valorii stocului de la un
    anumit producator oferit ca parametru
    • Obtinerea valorii totale a stocului per
    categorie

• Suplimentar
    • Adaugare de produs
    • Va adauga automat si eticheta
    • Obtinerea valorii stocului per categorie
    per producator (?!) 
 */

using lab17;
using lab17.Models;

//Seed();

//StoreManager.ChangeProductPrice(10, 1600.9);

//StoreManager.AddCategory("Books", "...");

//double s = StoreStatistics.GetTotalStockPrice();
//Console.WriteLine(s);

//double t = StoreStatistics.GetStockPriceByManufacturer(4);
//Console.WriteLine(t);

//var list = StoreStatistics.GetStockPriceForEachCategory();

//list.ForEach(Console.WriteLine);

//StoreManager.DeleteManufacturer(1);

//Reset();

static void Seed()
{
    using var storeCtx = new StoreDBContext();
  
    // Manufacturers
    var samsungMnfctr = new Manufacturer
    {
        Name = "Samsung",
        Address = "Havana",
        CUI = "11122233",
    };
    var eleganceMnfctr = new Manufacturer
    {
        Name = "Elegance",
        Address = "Bonn",
        CUI = "22233344",
    };
    var gelatoMnfctr = new Manufacturer
    {
        Name = "Gelato",
        Address = "Colorado",
        CUI = "33344455",
    };

    // Categories
    var phonesCtgry = new Category
    {
        Name = "Phones",
        Pictogram = "...",
    };
    var tabletsCtgry = new Category
    {
        Name = "Tablets",
        Pictogram = "..."
    };
    var clothesCtgry = new Category
    {
        Name = "Clothes",
        Pictogram = "..."
    };
    var iceCreamCtgry = new Category
    {
        Name = "Ice Cream",
        Pictogram = "..."
    };

    // Labels + Products & Add to DB
    var glxyXLbl = new Label
    {
        Barcode = Guid.NewGuid(),
        Price = 5000.99,

    };
    var glxyXPrdct = new Product
    {
        Name = "Galaxy X",
        Stock = 10,
        Manufacturer = samsungMnfctr,
        Category = phonesCtgry,
        Label = glxyXLbl
    };

    storeCtx.Labels.Add(glxyXLbl);
    storeCtx.Products.Add(glxyXPrdct);

    var glxyYLbl = new Label
    {
        Barcode = Guid.NewGuid(),
        Price = 3500.99,

    };
    var glxyYPrdct = new Product 
    {
        Name = "Galaxy Y",
        Stock = 20,
        Manufacturer = samsungMnfctr,
        Category = tabletsCtgry,
        Label = glxyYLbl
    };

    storeCtx.Labels.Add(glxyYLbl);
    storeCtx.Products.Add(glxyYPrdct);

    var dressLbl = new Label
    {
        Barcode = Guid.NewGuid(),
        Price = 1500.90,
    };
    var dressPrdct = new Product 
    {
        Name = "black dress",
        Stock = 5,
        Manufacturer = eleganceMnfctr,
        Category = clothesCtgry,
        Label = dressLbl
    };

    storeCtx.Labels.Add(dressLbl);
    storeCtx.Products.Add(dressPrdct);

    var iceCreamCupLbl = new Label
    {
        Barcode = Guid.NewGuid(),
        Price = 15.90,
    };
    var icecreamCupPrdct = new Product 
    {
        Name = "Ice Cream Cup",
        Stock = 20,
        Manufacturer = gelatoMnfctr,
        Category = iceCreamCtgry,
        Label = iceCreamCupLbl
    };

    storeCtx.Labels.Add(iceCreamCupLbl);
    storeCtx.Products.Add(icecreamCupPrdct);

    var iceCreamConeLbl = new Label
    {
        Barcode = Guid.NewGuid(),
        Price = 21.99,
    };
    var icecreamConePrdct = new Product 
    {
        Name = "Ice Cream Cone",
        Stock = 25,
        Manufacturer = gelatoMnfctr,
        Category = iceCreamCtgry,
        Label = iceCreamConeLbl
    };

    storeCtx.Labels.Add(iceCreamConeLbl);
    storeCtx.Products.Add(icecreamConePrdct);

    // Add products to catregories
    phonesCtgry.Products.Add(glxyXPrdct);
    tabletsCtgry.Products.Add(glxyYPrdct);
    clothesCtgry.Products.Add(dressPrdct);
    iceCreamCtgry.Products.Add(icecreamCupPrdct);
    iceCreamCtgry.Products.Add(icecreamConePrdct);

    // Add products to manufacturers
    samsungMnfctr.Products.Add(glxyXPrdct);
    samsungMnfctr.Products.Add(glxyYPrdct);
    eleganceMnfctr.Products.Add(dressPrdct);
    gelatoMnfctr.Products.Add(icecreamCupPrdct);
    gelatoMnfctr.Products.Add(icecreamConePrdct);

    // Add Manufacturers to DB
    storeCtx.Manufacturers.Add(samsungMnfctr);
    storeCtx.Manufacturers.Add(eleganceMnfctr);
    storeCtx.Manufacturers.Add(gelatoMnfctr);

    // Add Catregories to DB
    storeCtx.Categories.Add(phonesCtgry);
    storeCtx.Categories.Add(tabletsCtgry);
    storeCtx.Categories.Add(clothesCtgry);
    storeCtx.Categories.Add(iceCreamCtgry);


    storeCtx.SaveChanges();
}

static void Reset()
{
    using var storeCtx = new StoreDBContext();

    var manufacturersIds = storeCtx.Manufacturers.Select(m => m.Id).ToList();
    manufacturersIds.ForEach(m => StoreManager.DeleteManufacturer(m));

    var categoriesIds = storeCtx.Categories.Select(c => c.Id).ToList();
    categoriesIds.ForEach(c => StoreManager.DeleteCategory(c));

    var labelsIds = storeCtx.Labels.Select(l => l.Id).ToList();
    labelsIds.ForEach(l => StoreManager.DeleteLabel(l));

    storeCtx.SaveChanges();
}