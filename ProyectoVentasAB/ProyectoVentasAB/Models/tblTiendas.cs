using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoVentasAB.Models
{
  public class tblTiendas
  {
    [Key]
    public int IdTienda { get; set; }

    [Required]
    [Display(Name = "Nombre")]
    public string NombreTienda { get; set; }

    [Required]
    public string Direccion { get; set; }

    public string Telefono { get; set; }

    public string Encargado { get; set; }

    //Relacion de Listado

    public virtual ICollection<tblVentas> Ventas { get; set; }
  }
}
