namespace NiceConsole
{
    internal interface IPerson
    {
        public int MyProperty { get; set; }
        public abstract string GetNameAndId();
    }
}