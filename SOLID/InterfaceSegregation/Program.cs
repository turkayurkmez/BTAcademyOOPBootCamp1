namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public interface IMessage
    {
        string From { get; set; }
        string To { get; set; }

        string Subject { get; set; }

        string Body { get; set; }




    }

    public interface IVideoMessage : IMessage
    {
        string VideoFormat { get; set; }
        int Duration { get; set; }
    }

    public interface IPictureMessage : IMessage
    {
        int ImageSize { get; set; }
        string ImageFormat { get; set; }
    }

    public class TextMessage : IMessage
    {
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class VideoMessage : IVideoMessage
    {
        public string VideoFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class ImageMessage : IPictureMessage
    {
        public int ImageSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ImageFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}