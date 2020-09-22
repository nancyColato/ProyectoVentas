using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoVentasAB.Models;

namespace ProyectoVentasAB.Data
{
  public class ApplicationDbContext : IdentityDbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<tblCategorias> Categorias { get; set; }
    public DbSet<tblProductos> Productos { get; set; }
    public DbSet<tblVentas> Ventas { get; set; }
    public DbSet<tblTiendas> Tiendas { get; set; }

  }
}
