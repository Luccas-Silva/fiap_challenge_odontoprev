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
    public class ConsultaController : Controller
    {
        private readonly ApplicationContext _context;

        public ConsultaController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Consulta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consulta.ToListAsync());
        }

        // GET: Consulta/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultaEntity = await _context.Consulta
                .FirstOrDefaultAsync(m => m.idConsulta == id);
            if (consultaEntity == null)
            {
                return NotFound();
            }

            return View(consultaEntity);
        }

        // GET: Consulta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consulta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idConsulta,dateConsulta,tipoConsulta,valorMedioConsulta")] ConsultaEntity consultaEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consultaEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consultaEntity);
        }

        // GET: Consulta/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultaEntity = await _context.Consulta.FindAsync(id);
            if (consultaEntity == null)
            {
                return NotFound();
            }
            return View(consultaEntity);
        }

        // POST: Consulta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("idConsulta,dateConsulta,tipoConsulta,valorMedioConsulta")] ConsultaEntity consultaEntity)
        {
            if (id != consultaEntity.idConsulta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultaEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaEntityExists(consultaEntity.idConsulta))
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
            return View(consultaEntity);
        }

        // GET: Consulta/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultaEntity = await _context.Consulta
                .FirstOrDefaultAsync(m => m.idConsulta == id);
            if (consultaEntity == null)
            {
                return NotFound();
            }

            return View(consultaEntity);
        }

        // POST: Consulta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var consultaEntity = await _context.Consulta.FindAsync(id);
            if (consultaEntity != null)
            {
                _context.Consulta.Remove(consultaEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaEntityExists(string id)
        {
            return _context.Consulta.Any(e => e.idConsulta == id);
        }
    }
}
