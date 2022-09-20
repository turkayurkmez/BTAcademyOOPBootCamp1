namespace InterfaceNedir
{

    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public IAddress Address { get; set; }
    }

    public interface IAddress
    {
        string City { get; set; }
        string Street { get; set; }
        string Country { get; set; }
    }

    public class HomeAddress : IAddress
    {
        public string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Street { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class WorkAddress : IAddress
    {
        public string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Street { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
