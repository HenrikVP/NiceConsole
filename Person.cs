namespace NiceConsole
{
    abstract internal class Person
    {
        public static int staticID;
        public int ID { get; set; }
        public string Name { get; set; } = "John Doe";

        virtual public int GetId()
        {
            return ID;
        }

        abstract public string GetName();
        
    }
}
