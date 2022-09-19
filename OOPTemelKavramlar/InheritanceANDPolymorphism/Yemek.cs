namespace InheritanceANDPolymorphism
{
    public class Yemek
    {
        //Her yemeğin ..................... vardır
        public List<string> Malzemeler { get; set; }
        public int PismeSuresi { get; set; }
        public string Aciklama { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{PismeSuresi} dakika boyunca {GetType().Name} yemeği pişirildi");
        }

        //Eğer İSTENİRSE (Gerekirse) ez:
        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} Yanında pilav ile sunuluyor.");
        }


    }

    public class SebzeYemegi : Yemek
    {
        public bool ZeytinYagliMi { get; set; }

    }

    public class Pirasa : SebzeYemegi
    {
        public bool HavucVarMi { get; set; }
    }

    public class EtYemegi : Yemek
    {
        public string EtTuru { get; set; }
    }

    public class Kofte : EtYemegi
    {

    }

    public class TulumbaTatlisi : Yemek
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} Yanında dondurma ile sunuluyor.");
        }
    }


}
