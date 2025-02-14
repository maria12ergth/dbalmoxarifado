using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SECRETARIAController : ControllerBase
    {
        private readonly ICategoriaRepositorio _db;
        public CategoriaController(ISECRETARIARepositorio db)
        {
            _db = db;

        }

        [HttpGet("/lista")]
        public IActionResult listSECRETARIA()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/ SECRETARIA")]
        public IActionResult listaSECRETARIA(SECRETARIADTO  SECRETARIA)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == SECRETARIA.Codigo));
        }

        [HttpPost("/criar SECRETARIA")]
        public IActionResult criarSECRETARIA(SECRETARIA CadastroDTO  SECRETARIA)
        {

            var novaCategoria = new SECRETARIA()
            {
                Descricao = SECRETARIA.Descricao
            };
            //_ SECRETARIA.Add(novaSECRETARIA);
            _db.Add(novaSECRETARIA);
            return Ok("Cadastro com Sucesso");
        }

    }
}
