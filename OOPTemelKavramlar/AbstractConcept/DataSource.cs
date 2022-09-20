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
            Console.WriteLine($"{data}, XML kaynağına yazıldı");
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
            Console.WriteLine($"{data}, DB kaynağına yazıldı");
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
            Console.WriteLine($"{data}, Excel kaynağına yazıldı");
        }
    }


    public class DataSourceWriter
    {

        public void WriteData(string data, DataSource dataSource)
        {
            dataSource.GetConfig();
            dataSource.Write(data);
        }
    }
}
