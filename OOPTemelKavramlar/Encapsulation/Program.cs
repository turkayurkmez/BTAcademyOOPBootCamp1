
namespace Encapsulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Urun pc = new Urun();
            var fiyat = 8;
            //if (fiyat<0)
            //{
            //    Console.WriteLine("fiyat sıfırdan küçük olamaz.");
            //}
            //pc.Fiyat = -65;
            pc.SetFiyat(fiyat);
            var sonuc = pc.GetFiyat();
            Console.WriteLine(sonuc.ToString());

        }
    }
}

