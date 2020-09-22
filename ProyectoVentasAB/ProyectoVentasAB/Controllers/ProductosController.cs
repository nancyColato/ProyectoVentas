using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoVentasAB.Data;
using ProyectoVentasAB.Models;

namespace ProyectoVentasAB.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
          //envimos a vista
          ViewBag.Categoria = await _context.Categorias.ToListAsync();
          return View(await _context.Productos.ToListAsync());
        }


        // GET: Productos/Create
        public IActionResult Create()
        {

            //llamadaa tblCATEGORIA y envio a vista
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "IdCategoria", "NombreCategoria");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProducto,NombreProducto,FechaVencimiento,Descripcion,IdCategoria")] tblProductos tblProductos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblProductos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
          //llamadaa tblCATEGORIA y envio a vista
          ViewData["IdCategoria"] = new SelectList(_context.Categorias, "IdCategoria", "NombreCategoria");
          return View(tblProductos);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProductos = await _context.Productos.FindAsync(id);
            if (tblProductos == null)
            {
                return NotFound();
            }
            //llamadaa tblCATEGORIA y envio a vista
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "IdCategoria", "NombreCategoria");
            return View(tblProductos);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProducto,NombreProducto,FechaVencimiento,Descripcion,IdCategoria")] tblProductos tblProductos)
        {
            if (id != tblProductos.IdProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblProductos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblProductosExists(tblProductos.IdProducto))
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
            //llamadaa tblCATEGORIA y envio a vista
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "IdCategoria", "NombreCategoria");
            return View(tblProductos);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProductos = await _context.Productos
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (tblProductos == null)
            {
                return NotFound();
            }
            //llamadaa tblCATEGORIA y envio a vista
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "IdCategoria", "NombreCategoria");
            return View(tblProductos);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblProductos = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(tblProductos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblProductosExists(int id)
        {
            return _context.Productos.Any(e => e.IdProducto == id);
        }
    }
}
