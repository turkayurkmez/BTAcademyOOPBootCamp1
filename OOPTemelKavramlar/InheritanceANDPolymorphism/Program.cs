namespace InheritanceANDPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kofte kofte = new Kofte();
            kofte.PismeSuresi = 25;

            Pirasa pirasa = new Pirasa();
            pirasa.PismeSuresi = 15;

            TulumbaTatlisi tulumbaTatlisi = new TulumbaTatlisi();
            tulumbaTatlisi.PismeSuresi = 60;

            Asci asci = new Asci();
            asci.Pisir(kofte);
            asci.Pisir(pirasa);
            asci.Pisir(tulumbaTatlisi);



            //Oyuncu oyuncu = new Oyuncu();
            //oyuncu.OyuncununSilahi = new Ak47();


        }
    }
}

