using System.Collections.Generic;
using System.Data.SqlClient;
using microserviceProdutoApi.Models;

namespace microserviceProdutoApi.Infra
{
    public class BaseRepository
    {
        private static string ConnectionString => "teste";

        public void meu()
        {
            if (ConnectionString.Length > 0) return;
        }

        public List<Produto> Get()
        {
            using(SqlConnection connection)

            return new List<Produto>();
        }
    }
}