using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class SQLDBHelper
    {
        private SqlConnection sqlConnection = null;
        public SQLDBHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteCommand(string commandText, Dictionary<string, object> parameters)
        {

            SqlCommand sqlCommand = CreateCommand(commandText, parameters);
            sqlCommand.Connection.Open();
            var result = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();

            return result;
        }

        private SqlCommand CreateCommand(string commandText, Dictionary<string, object> parameters)
        {
            var command = sqlConnection.CreateCommand();
            command.CommandText = commandText;
            AddParametersToCommand(command, parameters);
            return command;
        }

        private void AddParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var item in parameters)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
        }
    }
}
