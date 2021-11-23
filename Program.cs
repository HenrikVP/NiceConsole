// See https://aka.ms/new-console-template for more information
using NiceConsole;

Console.WriteLine("Det blev ... " + (new Random().Next(16)+1));

Console.WriteLine("Hello, Basement!");
Data d = new();
Console.WriteLine(d.Who);

Console.WriteLine($"Years to release : {d.Henrik.GetYearsLeft()}");
;
Console.WriteLine("");
//d.Who.Cure(d.Henrik);

d.Mai.Cure(d.Who);

d.Mai.Torture(d.Who);
//d.Mai.Torture(d.Henrik);



//List<Person> Everyone = new()
//{
//    new Personale() { ID = 4, Name = "Hans", WorkerType = Personale.Workfunction.Cook },
//    d.Who,
//    d.Mai,
//    d.Henrik
//};
//Everyone.Add(new Personale { ID =1, Name= "?", WorkerType=Personale.Workfunction.Priest});

foreach (Person p in Data.personList)
{
    Console.WriteLine(p.Name);
}

/*
Mai Kælder
    Person
        Personale
            Læge
            Fangevogtere
            Kok
        Fanger
            Adelelige
            Pøblen

    Rum
        DampVaskeri
        Køkken
        Torturkælder
        Gummicelle
        Fælles Bad
        Celler
            Har vindue?
            Antal Fanger
            Antal toiletter
            Antal Rotter
            Antal Senge
    
    Våben
        Shank type

    Torturinstrumenter

 */
