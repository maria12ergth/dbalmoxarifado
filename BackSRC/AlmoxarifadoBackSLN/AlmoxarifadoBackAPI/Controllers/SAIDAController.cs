using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SAIDAController : ControllerBase
    {
        private readonly ICategoriaRepositorio _db;
        public CategoriaSAIDA(ISAIDARepositorio db)
        {
            _db = db;

        }

        [HttpGet("/lista")]
        public IActionResult listaSAIDA()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/SAIDA")]
        public IActionResult listaSAIDA(SAIDADTO SAIDA)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == SAIDA.Codigo));
        }

        [HttpPost("/criarSAIDA")]
        public IActionResult criarSAIDA(SAIDACadastroDTO SAIDA)
        {

            var novaCategoria = new SAIDA()
            {
                Descricao = SAIDA.Descricao
            };
            //_SAIDA.Add(novaSAIDA);
            _db.Add(nova SAIDA);
            return Ok("Cadastro com Sucesso");
        }

    }
}
