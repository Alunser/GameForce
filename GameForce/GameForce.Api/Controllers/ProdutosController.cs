using GameForme.Domain.Produtos.Incluir.Commands;
using GameForme.Domain.Produtos.Incluir.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace GameForce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly List<Produto> _produtos;
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult<Produto> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Post([FromBody] IncluirProdutoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
