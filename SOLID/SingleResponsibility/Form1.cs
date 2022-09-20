namespace SingleResponsibility
{
    public partial class Form1 : Form
    {

        /*
         * Her nesnenin sadece bir sorumluluğu olmalı. Muhasebeciye kod yazdıramazsanız; nesneye de sorumluluğu dışında iş vermeyin.
         * 
         * Bir nesne tanımında kod değişikliği yapmak için birden fazla sebebiniz varsa bu prensibi ihlal ediyorsunuz demektir.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True");

            //SqlCommand sqlCommand = new SqlCommand("Insert into Products (ProductName,UnitPrice) values (@name,@price)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@name", textBoxName.Text);
            //sqlCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(textBoxPrice.Text));

            //sqlConnection.Open();
            //var rowAffected = sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            ProductService productService = new ProductService();
            var rows = productService.AddProduct(name, price);

            var message = rows > 0 ? "İşlem başarılı" : "Başarısız";
            MessageBox.Show(message);

        }
    }
}