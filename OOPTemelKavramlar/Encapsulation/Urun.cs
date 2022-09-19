namespace Encapsulation
{
    public class Urun
    {
        public string Ad;
        private decimal fiyat;

        public void SetFiyat(decimal deger)
        {
            if (deger > 0)
            {
                fiyat = deger;
            }
            else
            {
                throw new Exception("Değer 0'dan büyük olmalıdır!");
            }

        }

        public decimal GetFiyat()
        {
            return fiyat;
        }


    }
}
