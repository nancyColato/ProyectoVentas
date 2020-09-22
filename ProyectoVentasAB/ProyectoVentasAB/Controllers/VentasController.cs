using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoVentasAB.Data;
using ProyectoVentasAB.Models;

namespace ProyectoVentasAB.Controllers
{
  [Authorize]
  public class VentasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VentasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {

            ViewBag.Producto = await _context.Productos.ToListAsync();
            ViewBag.Tienda = await _context.Tiendas.ToListAsync();
            return View(await _context.Ventas.ToListAsync());
        }

    // GET: Ventas/Details/5
    //public async Task<IActionResult> Details(int? id)
    //{
    //  if (id == null)
    //  {
    //    return NotFound();
    //  }

    //  var tblVentas = await _context.Ventas
    //      .FirstOrDefaultAsync(m => m.IdVenta == id);
    //  if (tblVentas == null)
    //  {
    //    return NotFound();
    //  }

    //  return View(tblVentas);
    //}

    // GET: Ventas/Create

    public IActionResult Create()
        {

          ViewBag.Tienda = _context.Tiendas.ToList();
          ViewBag.Producto = _context.Productos.ToList();
          ViewData["IdTienda"] = new SelectList(_context.Tiendas, "IdTienda", "NombreTienda");
          return View();
        }

    // POST: Ventas/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVenta,FechaVenta,Cantidad,Precio,SubTotal,Total,IdProducto,IdTienda")] tblVentas tblVentas)
        {
          if (ModelState.IsValid)
          {
            _context.Add(tblVentas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
          }
          ViewBag.Tienda = _context.Tiendas.ToList();
          ViewBag.Producto = _context.Productos.ToList();
          ViewData["IdTienda"] = new SelectList(_context.Tiendas, "IdTienda", "NombreTienda");
          return View(tblVentas);
        }

       

        // GET: Ventas/Delete/5
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVentas = await _context.Ventas
                .FirstOrDefaultAsync(m => m.IdVenta == id);
            if (tblVentas == null)
            {
                return NotFound();
            }

            return View(tblVentas);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblVentas = await _context.Ventas.FindAsync(id);
            _context.Ventas.Remove(tblVentas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblVentasExists(int id)
        {
            return _context.Ventas.Any(e => e.IdVenta == id);
        }
    }
}
