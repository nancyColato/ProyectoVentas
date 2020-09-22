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
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var tblVentas = await _context.Ventas
        //        .FirstOrDefaultAsync(m => m.IdVenta == id);
        //    if (tblVentas == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tblVentas);
        //}

        // GET: Ventas/Create
        
        public IActionResult Create()
        {

            ViewBag.Producto =  _context.Productos.ToList();
            ViewBag.Tienda =  _context.Tiendas.ToList();
            return View();
        }

    // POST: Ventas/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Create([Bind("IdVenta,FechaVenta,Cantidad,Precio,SubTotal,Total,IdProducto,IdTienda")] tblVentas tblVentas)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        _context.Add(tblVentas);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }
    //    return View(tblVentas);
    //}

    // GET: Ventas/Edit/5

        [HttpPost]
        public async Task<IActionResult> Create(int id, int codigo, DateTime fecha, int cantidad, int idP, float precio, float stotal)
        {
          try
          {


            tblVentas venta = new tblVentas();
            venta.IdTienda = id;
            venta.IdVenta = codigo;
            venta.FechaVenta = fecha;
            venta.IdProducto = idP;
            venta.Cantidad = cantidad;
            venta.SubTotal = precio;
            venta.Total = stotal;

            _context.Add(venta);
            await _context.SaveChangesAsync();
            return Json(true);
          }
          catch (Exception e)
          {
            Console.WriteLine(e.Message);
            return Json(false);
          }
        }
        //public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var tblVentas = await _context.Ventas.FindAsync(id);
        //        if (tblVentas == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(tblVentas);
        //    }

        // POST: Ventas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("IdVenta,FechaVenta,Cantidad,Precio,SubTotal,Total,IdProducto,IdTienda")] tblVentas tblVentas)
        //{
        //    if (id != tblVentas.IdVenta)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(tblVentas);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!tblVentasExists(tblVentas.IdVenta))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(tblVentas);
        //}

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
