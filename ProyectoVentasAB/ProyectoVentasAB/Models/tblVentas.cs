using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoVentasAB.Models
{
  public class tblVentas
  {
    [Key]
    public int IdVenta { get; set; }

    [Required]
    [Display(Name = "Fecha de Venta")]
    public DateTime FechaVenta { get; set; }
    public int Cantidad { get; set; }
    public float Precio { get; set; }
    public float SubTotal { get; set; }
    [Required]
    public float Total { get; set; }

    //RELACIONES
    [Display(Name = "Producto")]
    public int IdProducto { get; set; }
    public virtual tblProductos Productos { get; set; }

    //RELACIONES
    [Display(Name = "Tienda")]
    public int IdTienda { get; set; }
    public virtual tblTiendas Tiendas { get; set; }
  }
}
