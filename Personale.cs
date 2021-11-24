namespace NiceConsole
{
    internal class Personale : Person, IPerson
    {
        public enum Workfunction { Doctor, Cook, Guard, Manager, Priest, HeadOfInterrogation, None }
        public Workfunction WorkerType { get; set; }
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public bool Cure(Person person)
        {
            if (WorkerType != Workfunction.Doctor)
            {
                Console.WriteLine($"{Name} is not a doctor!");
                return false;
            }

            int chance = new Random().Next(100);
            if (person is Personale)
            {
                Console.WriteLine($"{person.Name} is Personel, and will recieve the best treatment");
                if (chance > 20)
                {
                    Console.WriteLine($"{person.Name} is cured!");
                    return true;
                }
                else return false;
            }
            else if (person is Prisoner)
            {
                Console.WriteLine($"{person.Name} is scum. Good luck.");
            }

            return true;
        }
        public bool Torture(Person person)
        {
            if (WorkerType != Workfunction.HeadOfInterrogation)
            {
                Console.WriteLine($"{Name} is not an interrogator!");
                return false;
            }

            int chance = new Random().Next(100);
            if (person is Prisoner)
            {
                Console.WriteLine($"{person.Name} is prisoner, and will recieve the worst treatment");
                if (chance < 85)
                {
                    Console.WriteLine($"{person.Name} has spilled the beans!");
                    return true;
                }
                else
                {
                    Console.WriteLine("The Prisoner didn't confess");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("We only torture prisoners here. We are not savages.");
                return false;
            }
        }

        //public Personale(List<Personale> pList,string name, Workfunction workerType)
        //{
        //    staticID++;
        //    ID = staticID;
        //    Name = name;
        //    WorkerType = workerType;

        //    pList.Add(this);
        //}
        //public Personale(List<Personale> pList, string name)
        //{
        //    staticID++;
        //    ID = staticID;
        //    Name = name;
        //    pList.Add(this);
        //}
        public Personale(List<Person> pList, string name, Workfunction workerType = Workfunction.None)
        {
            staticID++;
            ID = staticID;
            Name = name;
            pList.Add(this);
        }

        public override int GetId()
        {
            Console.WriteLine($"Id is : {ID}");
            return ID;
        }

        public override string GetName()
        {
            return Name;
        }

        public string GetNameAndId()
        {
            throw new NotImplementedException();
        }
    }
}
