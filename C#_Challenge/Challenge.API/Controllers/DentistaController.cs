using Challenge.API.Domains.Entities;
using Challenge.API.Infrastructure.Data.AppData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DentistaController : ControllerBase
    {
        
        private readonly ApplicationContext _context;

        public DentistaController(ApplicationContext _context) 
        {
            _context = _context;
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
            var dentistas = _context.Dentista.ToList();
            return Ok(dentistas);
        }

        [HttpGet("{cpf_cnpj}")]
        public IActionResult GetDentistaId(string cpf_cnpj)
        {
            var dentista = _context.Dentista.FirstOrDefault(x => x.cpf_cnpj == cpf_cnpj);
            return Ok(dentista);
        }

        [HttpPost]
        public IActionResult PostDentista([FromBody] DentistaEntity dentista)
        {
            _context.Dentista.Add(dentista);
            _context.SaveChanges();

            return Ok(dentista);
        }

        [HttpDelete("{cpf_cnpj}")]
        public IActionResult DeleteDentista(string cpf_cnpj)
        {
            var dentista = _context.Dentista.FirstOrDefault(x => x.cpf_cnpj == cpf_cnpj);

            if (dentista is not null) 
            {
                _context.Dentista.Remove(dentista);
                _context.SaveChanges();

                return Ok(dentista);
            }
            return BadRequest();

        }

    }
}
