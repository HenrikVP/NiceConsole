// See https://aka.ms/new-console-template for more information
using NiceConsole;

Console.WriteLine("Det blev ... " + (new Random().Next(16)+1));

Console.WriteLine("Hello, Basement!");
Data d = new();
d.StartSystem();

//Console.WriteLine(d.Who);

//Console.WriteLine($"Years to release : {d.Henrik.GetYearsLeft()}");
//;
//Console.WriteLine("");
////d.Who.Cure(d.Henrik);

//d.Mai.Cure(d.Who);

//d.Mai.Torture(d.Who);
//d.Mai.Torture(d.Henrik);

//Queue<Person> VIP = new();
//Queue<Person> NonVIP = new();

//foreach (Person p in Data.personList)
//{
//    if (p is Personale || ((Prisoner)p).Type == Prisoner.PrisonerType.VIP || ((Prisoner)p).Type == Prisoner.PrisonerType.Snitch)
//    {
//        VIP.Enqueue(p);
//    }
//    else if (p is Prisoner)
//    {
//        NonVIP.Enqueue(p);
//    }

//}

//Console.WriteLine("Press enter for next: ");

//if (VIP.Count>0)
//{ VIP.Dequeue(); }

//else if (NonVIP.Count > 0)
//{ NonVIP.Dequeue(); }

//Console.WriteLine("Vores list før: " + VIP.Count());

//foreach (Person qperson in VIP.ToList())
//{
//    Person p = VIP.Dequeue();
//    d.Who.Cure(p);
//}

//while (VIP.Count > 0) 
//{
//    Console.WriteLine("next in stack: " + VIP.Peek().Name);
//    Console.ReadKey();
//    Person p = VIP.Pop();
//    d.Who.Cure(p);
//}

////for (int i = 0; i < 4; i++)
////{
////    Person p = VIP.Pop();
////    d.Who.Cure(p);
////}


//Console.WriteLine("Vores list efter: " + VIP.Count());

//    new Personale() { ID = 4, Name = "Hans", WorkerType = Personale.Workfunction.Cook },
//    d.Who,
//    d.Mai,
//    d.Henrik
//};
//Everyone.Add(new Personale { ID =1, Name= "?", WorkerType=Personale.Workfunction.Priest});

//foreach (Person p in Data.personList)
//{
//    Console.WriteLine(p.Name);
//}

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
