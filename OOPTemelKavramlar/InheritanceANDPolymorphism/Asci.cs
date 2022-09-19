namespace InheritanceANDPolymorphism
{
    public class Asci
    {
        //Aşçı, yemek pişirir.
        public void Pisir(Yemek yemek)
        {
            yemek.Pisir();
            yemek.SunumYap();
        }
    }
}
