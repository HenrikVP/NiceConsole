namespace NiceConsole
{
    internal class Data
    {
        public static List<Person> personList = new();
        private Personale Who = new(personList, "Who?", Personale.Workfunction.Doctor);
        private Personale Mai = new(personList, "Mai", Personale.Workfunction.HeadOfInterrogation);

        private Personale Mil = new(personList, "HH");
        private Prisoner Henrik = new(
            personList,
            "Henry Morgan",
            new DateTime(2025, 11, 23),
            Prisoner.PrisonerType.Innocent
            );

        Queue<Person> VIP = new();
        Queue<Person> NonVIP = new();

        public void StartSystem()
        {
            AddToQueue();

            while (true)
            {
                Console.WriteLine("Press any key for next");
                Console.ReadKey(true);
                StartTicket();
            }
        }

        private void AddToQueue()
        {
            foreach (Person p in personList)
            {
                if (p is Personale || ((Prisoner)p).Type == Prisoner.PrisonerType.VIP || ((Prisoner)p).Type == Prisoner.PrisonerType.Snitch)
                {
                    VIP.Enqueue(p);
                }
                else if (p is Prisoner)
                {
                    NonVIP.Enqueue(p);
                }
            }
        }

        private void StartTicket()
        {
            Person? p = GetFromQueue();
            if (p == null)
            {
                Console.WriteLine("Chill out. No one in line");
            }
            else
            {
                Console.WriteLine("Next in line is : " + p.Name);
            }
        }

        private Person? GetFromQueue()
        {
            if (VIP.Count > 0) return VIP.Dequeue();
            else if (NonVIP.Count > 0) return NonVIP.Dequeue();
            else return null;
        }

    }
}
