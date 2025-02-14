using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class fornecedorController : ControllerBase
    {
        private readonly ICategoriaRepositorio _db;
        public fornecedorController(IfornecedorRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/lista")]
        public IActionResult listafornecedor()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/fornecedor")]
        public IActionResult listafornecedor(fornecedorDTO fornecedor)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == fornecedor.Codigo));
        }

        [HttpPost("/criarfornecedor")]
        public IActionResult criarfornecedor(fornecedorCadastroDTO fornecedor)
        {

            var novaCategoria = new fornecedor()
            {
                Descricao = fornecedor.Descricao
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novofornecedor);
            return Ok("Cadastro com Sucesso");
        }
    }
}
