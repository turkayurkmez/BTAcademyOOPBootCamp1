namespace Constructors
{
    public class CamasirMakinesi
    {
        public string Renk { get; set; }
        public int RotatePerMinute { get; set; }

        public int Kapasite { get; set; }


        //public CamasirMakinesi()
        //{
        //    Renk = "Beyaz";
        //    RotatePerMinute = 1200;
        //    Kapasite = 10;
        //}

        public CamasirMakinesi(string renk)
        {
            Renk = renk;
        }




        public CamasirMakinesi(int kapasite) : this("Beyaz")
        {
            Kapasite = kapasite;
            //Renk = "Beyaz";

        }

        public CamasirMakinesi(int kapasite, int rpm) : this("Beyaz")
        {
            Kapasite = kapasite;
            RotatePerMinute = rpm;
            //Renk = "Beyaz";

        }
    }
}
