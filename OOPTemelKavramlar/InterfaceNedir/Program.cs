namespace InterfaceNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PdfDocument pdf = new PdfDocument();
            ExcelDocument excel = new ExcelDocument();
            PowerPointDocument ppt = new PowerPointDocument();
            WordDocument wordDocument = new WordDocument();

            PrintDocument printDocument = new PrintDocument();
            printDocument.Print(wordDocument);
        }
    }
}