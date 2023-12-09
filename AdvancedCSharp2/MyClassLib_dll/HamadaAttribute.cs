namespace MyClassLib_dll
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple =true)]
    public class HamadaAttribute:Attribute
    {
        int id;
        string name;

        public HamadaAttribute(int _id, string _Name)
        {
            Id = _id;
            Name = _Name;
    }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}