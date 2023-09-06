Page First Page = new Page(Mynotes.VariablePageOne);

Page Second Page = new Page("Min anden side pÅ VEJ TIL BOMBMAN TYCOON");

Page Third Page = new Page("Min tredje side pÅ VEJ TIL BOMBMAN TYCOON");

Chapter Kapitel1 = new Chapter("Variable");

Kapitel1.Page.Add(FirstPage)
Kapitel1.Page.Add(SecondPage)
Kapitel1.Page.Add(ThirdPage)

Kapitel1.Read();

Console.WriteLine("Jones har en kæmpe diller");