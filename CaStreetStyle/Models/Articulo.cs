using Microsoft.AspNetCore.Mvc;
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
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "Debe ingresar la tasa del valor de la moneda!")]
        public double TasaMoneda { get; set; }
        public double MontoTotal { get; set; }

        public Articulo()
        {
            ArticuloId = 0;
            Nombre = string.Empty;
            Precio = 0;
            Ganancia = 0;
            FechaIngreso = DateTime.Now;
            TasaMoneda = 0;
            MontoTotal = 0;
        }

        public Articulo(string nombre, double precio, double ganancia, DateTime fechaIngreso, double tasaMoneda, double montoTotal)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Ganancia = ganancia;
            this.FechaIngreso = fechaIngreso;
            this.TasaMoneda = tasaMoneda;
            this.MontoTotal = montoTotal;
        }
    }
}
