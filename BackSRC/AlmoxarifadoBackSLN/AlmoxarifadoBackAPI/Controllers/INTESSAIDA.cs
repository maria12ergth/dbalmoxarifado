using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class INTESSAIDA : ControllerBase
    {
        private readonly ICategoriaRepositorio _db;
        public INTESSAIDA(INTESSAIDA Repositorio_db)
        {
            _db = db;

        }

        [HttpGet("/lista")]
        public IActionResult listaINTESSAIDA()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/INTESSAIDA")]
        public IActionResult lista(INTESSAIDADTO INTESSAIDA)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == INTESSAIDA.Codigo));
        }

        [HttpPost("/criarINTESSAIDA")]
        public IActionResult criarINTESSAIDA(INTESSAIDA CadastroDTO INTESSAIDA)
        {

            var novaCategoria = new INTESSAIDA()
            {
                Descricao = INTESSAIDA.Descricao
            };
            //_categorias.Add(novaINTESSAIDA);
            _db.Add(novaINTESSAIDA);
            return Ok("Cadastro com Sucesso");
        }
    }
}
