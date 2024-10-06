using Challenge.API.Domains.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DentistaController : ControllerBase
    {
        private List<DentistaEntity> _dentistas;
        public DentistaController() 
        {
            _dentistas = new List<DentistaEntity> {
                new DentistaEntity {cpf_cnpj = "1"},
                new DentistaEntity {cpf_cnpj = "2"},
                new DentistaEntity {cpf_cnpj = "3"},
                new DentistaEntity {cpf_cnpj = "4"},
            };
        }

        [HttpGet]
        public IActionResult GetDentista()
        {
            var dentista = new DentistaEntity();
            return Ok(dentista);
        }

        [HttpGet("dentistas")]
        public IActionResult GetListDentista()
        {
            return Ok(_dentistas);
        }

        [HttpGet("{cpf_cnpj}")]
        public IActionResult GetDentistaId(string cpf_cnpj)
        {
            var dentista = _dentistas.FirstOrDefault(x => x.cpf_cnpj == cpf_cnpj);
            return Ok(dentista);
        }

        [HttpPost]
        public IActionResult PostDentista([FromBody] DentistaEntity dentista)
        {
            _dentistas.Add(dentista);
            return Ok(dentista);
        }

        [HttpDelete("{cpf_cnpj}")]
        public IActionResult DeleteDentista(string cpf_cnpj)
        {
            var dentista = _dentistas.FirstOrDefault(x => x.cpf_cnpj == cpf_cnpj);
            _dentistas.Remove(dentista);
            return Ok();
        }

    }
}
