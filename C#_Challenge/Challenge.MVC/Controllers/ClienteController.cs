using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Challenge.MVC.AppData;
using Challenge.MVC.Models;

namespace Challenge.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationContext _context;

        public ClienteController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Cliente
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cliente.ToListAsync());
        }

        // GET: Cliente/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteEntity = await _context.Cliente
                .FirstOrDefaultAsync(m => m.cpf_cnpj == id);
            if (clienteEntity == null)
            {
                return NotFound();
            }

            return View(clienteEntity);
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cpf_cnpj,cep,tipoPlano")] ClienteEntity clienteEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clienteEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clienteEntity);
        }

        // GET: Cliente/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteEntity = await _context.Cliente.FindAsync(id);
            if (clienteEntity == null)
            {
                return NotFound();
            }
            return View(clienteEntity);
        }

        // POST: Cliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("cpf_cnpj,cep,tipoPlano")] ClienteEntity clienteEntity)
        {
            if (id != clienteEntity.cpf_cnpj)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clienteEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteEntityExists(clienteEntity.cpf_cnpj))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(clienteEntity);
        }

        // GET: Cliente/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteEntity = await _context.Cliente
                .FirstOrDefaultAsync(m => m.cpf_cnpj == id);
            if (clienteEntity == null)
            {
                return NotFound();
            }

            return View(clienteEntity);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var clienteEntity = await _context.Cliente.FindAsync(id);
            if (clienteEntity != null)
            {
                _context.Cliente.Remove(clienteEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteEntityExists(string id)
        {
            return _context.Cliente.Any(e => e.cpf_cnpj == id);
        }
    }
}
