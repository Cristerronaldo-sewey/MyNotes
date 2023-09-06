Page FirstPage = new Page("Første side hvor jeg snakker om JONES KÆMPPPE DILLER");

Page Second = new Page("How to remove Shreak emos aka Lebbe lone maja");

Page Third = new Page("Min tredje side pÅ VEJ TIL BOMBMAN TYCOON");

Page Four = new Page("Top D in the house aka joens");

Page fifth = new Page("Tykke Ebeson");

Page six = new Page("Lebbe ebbe ER MIN BItch");

Page seven = new Page("hOLD DA KÆFT NOGLE DEJLIGE RØVBALLER");

Page eight = new Page("Mister fister");



Chapter Kapitel1 = new Chapter("KaP 1.");


Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(Second);
Kapitel1.Pages.Add(Third);
Kapitel1.Pages.Add(Four);
Kapitel1.Pages.Add(fifth);
Kapitel1.Pages.Add(six);
Kapitel1.Pages.Add(seven);
Kapitel1.Pages.Add(eight);

Page KAP2 = new Page("SÅ ER DER SATANEME NYT KAPITEL");

Page Nine = new Page("Build diffrent");

Page Ten = new Page("Build diffrent");


Chapter Kapitel2 = new Chapter("Kap 2.");

Kapitel2.Pages.Add(KAP2);
Kapitel2.Pages.Add(Nine);
Kapitel2.Pages.Add(Ten);

 

Kapitel1.Read();
Kapitel2.Read();

Book mybook = new Book("Skadidle skadooodle ur dick is now a noodle");

mybook.Chapters.Add(Kapitel1);
mybook.Chapters.Add(Kapitel2);
mybook.Start();


Console.WriteLine("Jones har en kæmpe diller");
