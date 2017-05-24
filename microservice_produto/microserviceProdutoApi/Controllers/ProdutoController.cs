using System.Collections.Generic;
using microserviceProdutoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace microserviceProdutoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Produto")]
    public class ProdutoController : Controller
    {
        // GET api/Produto
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return new List<Produto>();
        }

        // GET api/Produto/5
        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            return new Produto();
        }
    }
}
