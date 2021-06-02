using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Apd2_20180240.Model
{
    public class Productos
    {
        [Key]
        [Required(ErrorMessage ="El ID es incorecto")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Descripsion no se puede dejar vacia")]
        public string Descripsion   { get; set; }
        
        [Required(ErrorMessage = "El dato Existencia es incorecto")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El dato Costo es incorecto")]
        public int Costo { get; set; }

        [Required(ErrorMessage = "El dato Inventario es incorecto")]
        public int Inventario { get; set; }


    }
}
