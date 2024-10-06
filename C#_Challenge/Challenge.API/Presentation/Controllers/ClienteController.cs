using Challenge.API.Domains.Entities;
using Challenge.API.Infrastructure.Data.AppData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.API.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ClienteController(ApplicationContext _context)
        {
            _context = _context;
        }

        [HttpGet]
        public IActionResult GetCliente()
        {
            var cliente = new ClienteEntity();
            return Ok(cliente);
        }

        [HttpGet("clientes")]
        public IActionResult GetListCliente()
        {
            var clientes = _context.Cliente.ToList();
            return Ok(clientes);
        }

        [HttpGet("{cpf_cnpj}")]
        public IActionResult GetClienteId(string cpf_cnpj)
        {
            var cliente = _context.Cliente.FirstOrDefault(x => x.cpf_cnpj == cpf_cnpj);
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult PostCliente([FromBody] ClienteEntity cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();

            return Ok(cliente);
        }

        [HttpDelete("{cpf_cnpj}")]
        public IActionResult DeleteCliente(string cpf_cnpj)
        {
            var cliente = _context.Cliente.FirstOrDefault(x => x.cpf_cnpj == cpf_cnpj);

            if (cliente is not null)
            {
                _context.Cliente.Remove(cliente);
                _context.SaveChanges();

                return Ok(cliente);
            }
            return BadRequest();

        }

    }

}

