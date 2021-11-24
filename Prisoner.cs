namespace NiceConsole
{
    internal class Prisoner: Person
    {
        public enum PrisonerType { VIP, Scum, Snitch, Innocent, Victim }
        public int YearsToServe { get; set; }
        public DateTime DateOfRelease { get; set; }
        public bool CanLeave { get; set; }     
        public PrisonerType Type {get; set;}
        public int Cell { get; set; }
        public Prisoner(List<Person> pList, string name, DateTime release, PrisonerType pt = PrisonerType.Victim)
        {
            staticID++;
            ID = staticID;
            Name = name;
            DateOfRelease = release;
            pList.Add(this);
        }

        public int GetYearsLeft()
        {
            int age = DateOfRelease.Year- DateTime.Now.Year;
            DateTime havePassedDate = new DateTime(DateTime.Now.Year, DateOfRelease.Month, DateOfRelease.Day);
            if (DateTime.Now < havePassedDate) age--;

            return age;
        }

        public override string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
