namespace InheritanceANDPolymorphism
{
    public class Oyuncu
    {
        //Her oyuncunun ................. vardır.
        public string Nick { get; set; }

        public Silah OyuncununSilahi { get; set; }

    }

    public class Silah
    {
        public int Agirlik { get; set; }
        public int VurusGucu { get; set; }
        public void Atak()
        {

        }
    }

    public class Bicak : Silah
    {

    }
    public class AtesliSilah : Silah
    {
        public bool SeriMi { get; set; }
        public int MaksimumMermi { get; set; }
    }

    public class Tufek : AtesliSilah
    {
        public bool DurbunVarMi { get; set; }
    }

    public class Ak47 : Tufek
    {

    }
}
