using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProyectoVentasAB.Data;
using ProyectoVentasAB.Models;

namespace ProyectoVentasAB.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
      _logger = logger;
      _context = context;

    }



    public async Task<IActionResult> Index()
    {
      ViewBag.Tienda = await _context.Tiendas.ToListAsync();
      ViewData["Tienda"] = new SelectList(_context.Tiendas, "IdTienda", "NombreTienda");

      //Paracategorias Vendidas
      var Consulta = _context.Ventas.ToList();
      var ConsultaP = _context.Productos.ToList();

      foreach (var cv in Consulta)
      {
        foreach (var cp in ConsultaP)
        {
          if (cv.IdProducto == cp.IdProducto)
          {
            var consult = _context.Productos.Select(x => x.IdCategoria);
            ViewBag.ConsultarC = consult.Distinct().Count();
          }
        }
      }

      //Para Ventas Total
      ViewBag.VentasTotales = _context.Ventas.Sum(v => v.Total);

      //Para Productos vendidos Totales
      ViewBag.ProductosVendidos = _context.Ventas.Sum(v => v.Cantidad);

      //Para tabla de ventas
      ViewBag.TopVentas = _context.Ventas.OrderBy(v => v.Total).ToList();

      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
