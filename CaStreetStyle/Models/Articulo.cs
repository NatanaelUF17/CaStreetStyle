using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace CaStreetStyle.Models
{
    public class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }
        [AllowNull]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el precio del producto!")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Debe ingresar la ganancia que desea tener!")]
        public double Ganancia { get; set; }
        public DateTime FechaIngreso => DateTime.Now;
        public Moneda Moneda { get; set; }

        public Articulo()
        {
            ArticuloId = 0;
            Nombre = string.Empty;
            Precio = 0;
            Ganancia = 0;
        }

        public Articulo(string nombre, double precio, double ganancia)
        {
            Nombre = nombre;
            Precio = precio;
            Ganancia = ganancia;
        }
    }
}
