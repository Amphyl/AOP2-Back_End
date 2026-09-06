using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaConsultas.Data;
using SistemaConsultas.Models;
using System.Security.Claims;

namespace SistemaConsultas.Controllers
{
    [Authorize]
    public class ConsultasController : Controller
    {
        private readonly AppDbContext _context;

        public ConsultasController(AppDbContext context)
        {
            _context = context;
        }

        private int GetUsuarioId() => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

        public async Task<IActionResult> Index()
        {
            var usuarioId = GetUsuarioId();
            var consultas = await _context.Consultas
                .Where(c => c.UsuarioId == usuarioId)
                .ToListAsync();
            return View(consultas);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Consulta consulta)
        {
            consulta.UsuarioId = GetUsuarioId(); 
            ModelState.Remove("Usuario"); 
            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consulta);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var consulta = await _context.Consultas.FirstOrDefaultAsync(c => c.Id == id && c.UsuarioId == GetUsuarioId());
            if (consulta == null) return NotFound();
            return View(consulta);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta != null && consulta.UsuarioId == GetUsuarioId())
            {
                _context.Consultas.Remove(consulta);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}