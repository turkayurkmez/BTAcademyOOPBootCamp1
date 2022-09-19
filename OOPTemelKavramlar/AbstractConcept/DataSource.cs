namespace AbstractConcept
{
    public abstract class DataSource
    {
        public string GetConfig()
        {
            return "Konfigürasyon verileri okunuyor";
        }
        public abstract void Write(string data);
        public abstract void Read();

    }

    public class XMLDataSource : DataSource
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string data)
        {
            throw new NotImplementedException();
        }
    }

    public class DbDataSource : DataSource
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string data)
        {
            throw new NotImplementedException();
        }
    }

    public class ExcelDataSource : DataSource
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string data)
        {
            throw new NotImplementedException();
        }
    }


}
