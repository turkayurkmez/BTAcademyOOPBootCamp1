namespace SingleResponsibility
{
    public class ProductService
    {
        /*
         * ProductService nesnesinin yalnızca db ile çalışması gerektiğine emin misiniz? Ya bir API ile çalışıyorsa; ya verileri Excel dosyasına atıyorsa? O zaman servisinizin Agnostik olduğuna emin olun
         */
        public int AddProduct(string name, decimal price)
        {
            var sqlConnectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";

            var commandText = "Insert into Products (ProductName,UnitPrice) values (@name,@price)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            var rowAffected = new SQLDBHelper(sqlConnectionString).ExecuteCommand(commandText, parameters);

            return rowAffected;
        }

        public int UpdateProduct(int id, string name)
        {
            return 1;
        }

        //public bool IsConnectedToDb()
        //{
        //    return false;
        //}
    }
}
