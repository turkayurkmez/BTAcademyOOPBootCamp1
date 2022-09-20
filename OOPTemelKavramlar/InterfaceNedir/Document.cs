namespace InterfaceNedir
{

    /*
     * Bir Interface; implemente ettiği sınıfa bir yetenek kazandırır. Ya da; birbirleri ile bağı olan  (couple) olan nesnelerin ihtiyacını minimuma indirger.
     * 
     */
    public abstract class Document
    {
        public void Copy(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine kopyalandı");
        }

        public void Move(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine taşındı");
        }

        public abstract void Save(string path);
        public abstract void Load(string path);



        //public abstract void Print();
    }


    public interface IPrintable
    {
        void Print();

    }

    public class PdfDocument : Document
    {
        public override void Load(string path)
        {
            throw new NotImplementedException();
        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save(string path)
        {
            Console.WriteLine($"Dosya, {path} adresine pdf olarak kaydedildi");
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Load(string path)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save(string path)
        {
            Console.WriteLine($"Dosya, {path} adresine excel olarak kaydedildi");

        }
    }

    public class PowerPointDocument : Document
    {
        public override void Load(string path)
        {
            throw new NotImplementedException();
        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save(string path)
        {
            Console.WriteLine($"Dosya, {path} adresine ppt olarak kaydedildi");

        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load(string path)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save(string path)
        {
            Console.WriteLine($"Dosya, {path} adresine docx olarak kaydedildi");

        }
    }

    public class PrintDocument
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}
