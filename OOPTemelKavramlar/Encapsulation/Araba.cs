namespace Encapsulation
{
    public class Araba
    {
        int hiz = 0;
        bool motorCalisiyorMu = false;
        public void GazaBas()
        {
            if (motorCalisiyorMu)
            {
                hiz++;
            }
        }

        public void Calistir()
        {
            motorCalisiyorMu = true;
        }
    }
}
