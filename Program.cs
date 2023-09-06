Page FirstPage = new Page("Første side hvor jeg snakker om JONES KÆMPPPE DILLER");

Page Second = new Page("How to remove Shreak emos aka Lebbe lone maja");

Page Third = new Page("Min tredje side pÅ VEJ TIL BOMBMAN TYCOON");

Chapter Kapitel1 = new Chapter("Variable");

Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(Second);
Kapitel1.Pages.Add(Third);

Kapitel1.Read();

Book mybook = new Book("Skadidle skadooodle ur dick is now a noodle");

mybook.Chapters.Add(Kapitel1);
mybook.Start();

Console.WriteLine("Variable");

Console.WriteLine("Jones har en kæmpe diller");
