namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CamasirMakinesi camasirMakinesi = new CamasirMakinesi(1200);
            Console.WriteLine(camasirMakinesi.Renk);

            CamasirMakinesi cm = new CamasirMakinesi(15, 2000);


        }
    }
}