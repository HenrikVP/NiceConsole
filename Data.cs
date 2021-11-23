namespace NiceConsole
{
    internal class Data
    {
        public static List<Person> personList = new();
        internal Personale Who = new(personList, "Who?", Personale.Workfunction.Doctor);
        internal Personale Mai = new(personList, "Mai", Personale.Workfunction.HeadOfInterrogation);

        internal Personale Mil = new(personList, "HH");
        internal Prisoner Henrik = new(
            personList,
            "Henry Morgan",
            new DateTime(2025,11,23),
            Prisoner.PrisonerType.Innocent
            );
    }
}
