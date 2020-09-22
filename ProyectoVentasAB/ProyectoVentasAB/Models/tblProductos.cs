using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoVentasAB.Models
{
  public class tblProductos
  {
    [Key]
    public int IdProducto { get; set; }

    [Required]

    [Display(Name = "Producto")]
    public string NombreProducto { get; set; }
    [Required]

    [Display(Name = "Vencimiento")]
    public DateTime FechaVencimiento { get; set; }

    public string Descripcion { get; set; }


    //RELACIONES
    [Display(Name = "Categoria")]
    public int IdCategoria { get; set; }
    public virtual tblCategorias Categorias { get; set; }

    //Relacion de Listado

    public virtual ICollection<tblVentas> Ventas { get; set; }
  }
}
