using System.Collections;
using System.Collections.Generic;
using microservices_produto.Infra;
using microservices_produto.Models;

namespace microservices_produto.Repository
{
    public class ProdutoRepository : BaseRepository
    {
        private enum Procedures
        {
            ListarProduto,
            SelecionarProduto
        }

        public IEnumerable<Produto> Get()
        {
            ExecuteProcedure(Procedures.ListarProduto);
            var produtos = new List<Produto>();
            using (var r = ExecuteReader())
                while (r.Read())
                    produtos.Add(new Produto
                    {
                        Id = r.GetInt32(r.GetOrdinal("Id")),
                        Nome = r.GetString(r.GetOrdinal("Nome")),
                        Preco = r.GetDecimal(r.GetOrdinal("Preco"))
                    });

            return produtos;
        }

        public Produto Get(int id)
        {
            ExecuteProcedure(Procedures.SelecionarProduto);
            AddParameter("@id", id);
            using (var r = ExecuteReader())
                if (r.Read())
                    return new Produto
                    {
                        Id = r.GetInt32(r.GetOrdinal("Id")),
                        Nome = r.GetString(r.GetOrdinal("Nome")),
                        Preco = r.GetDecimal(r.GetOrdinal("Preco"))
                    };

            return null;
        }
    }
}
