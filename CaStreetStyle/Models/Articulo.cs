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
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "Debe ingresar la ganancia que desea tener!")]
        public decimal Ganancia { get; set; }
        public decimal GananciaAumentada { get; set; }
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "Debe ingresar la tasa del valor de la moneda!")]
        public decimal TasaMoneda { get; set; }
        public decimal MontoTotal { get; set; }

        public Articulo()
        {
            ArticuloId = 0;
            Nombre = string.Empty;
            Precio = 0;
            Ganancia = 0;
            GananciaAumentada = 0;
            FechaIngreso = DateTime.Now;
            TasaMoneda = 0;
            MontoTotal = 0;
        }

        public Articulo(string nombre, decimal precio, decimal ganancia, DateTime fechaIngreso, decimal tasaMoneda, decimal montoTotal, decimal gananciaAumentada)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Ganancia = ganancia;
            this.FechaIngreso = fechaIngreso;
            this.TasaMoneda = tasaMoneda;
            this.MontoTotal = montoTotal;
            this.GananciaAumentada = gananciaAumentada;
        }
    }
}
