using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaStreetStyle.Models
{
    public class Moneda
    {
        [Key]
        public int MonedaId { get; set; }
        [Required(ErrorMessage = "El campo de la moneda no puede estar vacio!")]
        public double ValorMonetario { get; set; }

        public Moneda()
        {
            MonedaId = 0;
            ValorMonetario = 0;
        }
    }
}
