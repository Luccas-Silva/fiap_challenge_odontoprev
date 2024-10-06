using Challenge.API.Domains.Entities;
using Challenge.API.Infrastructure.Data.AppData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.API.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ConsultaController(ApplicationContext _context)
        {
            _context = _context;
        }

        [HttpGet]
        public IActionResult GetConsulta()
        {
            var consulta = new ConsultaEntity();
            return Ok(consulta);
        }

        [HttpGet("consultas")]
        public IActionResult GetListConsulta()
        {
            var consultas = _context.Consulta.ToList();
            return Ok(consultas);
        }

        [HttpGet("{idConsulta}")]
        public IActionResult GetConsultaId(string idConsulta)
        {
            var consulta = _context.Consulta.FirstOrDefault(x => x.idConsulta == idConsulta);
            return Ok(consulta);
        }

        [HttpPost]
        public IActionResult PostConsulta([FromBody] ConsultaEntity consulta)
        {
            _context.Consulta.Add(consulta);
            _context.SaveChanges();

            return Ok(consulta);
        }

        [HttpDelete("{idConsulta}")]
        public IActionResult DeleteConsulta(string idConsulta)
        {
            var consulta = _context.Consulta.FirstOrDefault(x => x.idConsulta == idConsulta);

            if (consulta is not null)
            {
                _context.Consulta.Remove(consulta);
                _context.SaveChanges();

                return Ok(consulta);
            }
            return BadRequest();

        }

    }
}
