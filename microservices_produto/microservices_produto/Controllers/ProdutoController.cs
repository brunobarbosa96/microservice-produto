using System.Collections.Generic;
using microservices_produto.Models;
using microservices_produto.Repository;
using Microsoft.AspNetCore.Mvc;

namespace microservices_produto.Controllers
{
    [Produces("application/json")]
    [Route("microservice/produto")]
    public class ProdutoController : Controller
    {
        private readonly ProdutoRepository _repository;

        public ProdutoController()
        {
            _repository = new ProdutoRepository();
        }

        // GET microservice/produto
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _repository.Get();
        }

        // GET microservice/produto/5
        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            return _repository.Get(id);
        }
    }
}
