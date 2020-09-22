using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoVentasAB.Models
{
  public class tblCategorias
  {
    [Key]
    public int IdCategoria { get; set; }

    [Required]
    [Display(Name = "Nombre")]
    public string NombreCategoria { get; set; }

    public string Descripcion { get; set; }


    //Relacion de Listado

    public virtual ICollection<tblProductos> Productos { get; set; }
  }
}
