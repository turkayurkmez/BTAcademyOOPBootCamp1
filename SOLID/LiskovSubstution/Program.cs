namespace LiskovSubstution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Square square = new Square();
            //Rectangle rectangle = new Rectangle();

            //square.Width = 5;
            //Console.WriteLine(square.GetArea());

            //rectangle.Width = 13;
            //rectangle.Height = 3;
            //Console.WriteLine(rectangle.GetArea());

            var rectangle = GetRectangle(5, 7);

            Console.WriteLine(rectangle.GetArea());

        }

        static IAreaCalcutable GetRectangle(int width, int? height = null)
        {
            if (!height.HasValue)
            {
                return new Square { EdgeLength = width };
            }
            return new Rectangle { Width = width, Height = height.Value };
        }
    }






    public interface IAreaCalcutable
    {
        int GetArea();
    }

    public class Rectangle : IAreaCalcutable
    {
        private int width;
        private int height;
        public virtual int Width { get => width; set => width = value; }
        public virtual int Height { get => height; set => height = value; }

        public int GetArea() => Width * Height;
    }

    public class Square : IAreaCalcutable //: Rectangle
    {
        //public override int Height { get => base.Height; set { base.Height = value; base.Width = value; } }
        //public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }

        public int EdgeLength { get; set; }

        public int GetArea() => EdgeLength * EdgeLength;


    }
}