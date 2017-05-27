using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace microservices_produto.Infra
{
    public class BaseRepository
    {
        //protected string ConnectionString => "Server=tcp:demo-microservice.database.windows.net,1433;Initial " +
        //                                     "Catalog=microservice-produto;Persist Security Info=False;" +
        //                                     "User ID=microservice;Password=t&ste123;MultipleActiveResultSets=False;" +
        //                                     "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected string ConnectionString => "Data Source=(localdb)\\v11.0;Initial Catalog=microservice;Integrated Security=True";

        private readonly SqlConnection _connection;
        private SqlCommand Command { get; set; }

        public BaseRepository()
        {
            _connection = Connect();
        }

        private SqlConnection Connect()
        {
            var connection = new SqlConnection(ConnectionString);
            if (connection.State == ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        protected void ExecuteProcedure(Enum procedureName)
        {
            Command = new SqlCommand(procedureName.ToString(), _connection) { CommandType = CommandType.StoredProcedure };
        }

        protected void AddParameter(string parameter, object value)
        {
            Command.Parameters.Add(new SqlParameter(parameter, value ?? DBNull.Value));
        }

        protected void ExecuteNonQuery()
        {
            Command.ExecuteNonQuery();
        }

        protected SqlDataReader ExecuteReader()
        {
            return Command.ExecuteReader();
        }
    }
}
