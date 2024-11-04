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
    public class DentistaController : Controller
    {
        private readonly ApplicationContext _context;

        public DentistaController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Dentista
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dentista.ToListAsync());
        }

        // GET: Dentista/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dentistaEntity = await _context.Dentista
                .FirstOrDefaultAsync(m => m.cpf_cnpj == id);
            if (dentistaEntity == null)
            {
                return NotFound();
            }

            return View(dentistaEntity);
        }

        // GET: Dentista/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dentista/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cpf_cnpj,cepClinica,nomeClinica,tipoClinica,alvaraFuncionamento,siteRedesSocial")] DentistaEntity dentistaEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dentistaEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dentistaEntity);
        }

        // GET: Dentista/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dentistaEntity = await _context.Dentista.FindAsync(id);
            if (dentistaEntity == null)
            {
                return NotFound();
            }
            return View(dentistaEntity);
        }

        // POST: Dentista/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("cpf_cnpj,cepClinica,nomeClinica,tipoClinica,alvaraFuncionamento,siteRedesSocial")] DentistaEntity dentistaEntity)
        {
            if (id != dentistaEntity.cpf_cnpj)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dentistaEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DentistaEntityExists(dentistaEntity.cpf_cnpj))
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
            return View(dentistaEntity);
        }

        // GET: Dentista/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dentistaEntity = await _context.Dentista
                .FirstOrDefaultAsync(m => m.cpf_cnpj == id);
            if (dentistaEntity == null)
            {
                return NotFound();
            }

            return View(dentistaEntity);
        }

        // POST: Dentista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dentistaEntity = await _context.Dentista.FindAsync(id);
            if (dentistaEntity != null)
            {
                _context.Dentista.Remove(dentistaEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DentistaEntityExists(string id)
        {
            return _context.Dentista.Any(e => e.cpf_cnpj == id);
        }
    }
}
