
using System.Linq;
using microservices_produto.Controllers;
using NUnit.Framework;

namespace microservices_produto.Tests
{
    [TestFixture]
    public class ProdutoTest
    {
        [Test]
        public void GetAll()
        {
            var produtoController = new ProdutoController();
            var produtos = produtoController.Get();

            Assert.IsNotNull(produtos);
            Assert.AreNotEqual(produtos.First().Id, 0);
        }

        [Test]
        public void Get()
        {
            var produtoController = new ProdutoController();
            var produtoNulo = produtoController.Get(-1);

            Assert.IsNull(produtoNulo);

            var produtoNaoNulo = produtoController.Get(1);
            Assert.IsNotNull(produtoNaoNulo);
            Assert.AreNotEqual(produtoNaoNulo.Id, 0);
        }
    }
}
