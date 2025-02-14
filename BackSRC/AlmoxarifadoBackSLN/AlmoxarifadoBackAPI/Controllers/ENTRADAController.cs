using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ENTRADAController : ControllerBase
    {
        private readonly ICategoriaRepositorio _db;
        public ENTRADAController(ICategoriaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/lista")]
        public IActionResult listaENTRADA()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/ENTRADA")]
        public IActionResult listaENTRADA(ENTRADADTO ENTRADA)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == ENTRADA.Codigo));
        }

        [HttpPost("/criarENTRADA")]
        public IActionResult criarENTRADA(ENTRADACadastroDTO ENTRADA)
        {

            var novaCategoria = new ENTRADA()
            {
                Descricao = ENTRADA.Descricao
            };
            //_ENTRADAS.Add(novaCategoria);
            _db.Add(novaENTRADA);
            return Ok("Cadastro com Sucesso");
        }
    }
}
