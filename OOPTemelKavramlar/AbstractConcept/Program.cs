namespace AbstractConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataSource excel = new ExcelDataSource();
            //Urun gidaUrunu = new Ekmek();
            DataSourceWriter writer = new DataSourceWriter();

            XMLDataSource xml = new XMLDataSource();
            DbDataSource dbDataSource = new DbDataSource();
            ExcelDataSource excelDataSource = new ExcelDataSource();

            writer.WriteData("Merhaba Dünya", xml);
            writer.WriteData("Merhaba Dünya", dbDataSource);
            writer.WriteData("Merhaba Dünya", excelDataSource);



        }
    }
}

