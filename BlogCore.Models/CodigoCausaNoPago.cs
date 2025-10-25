using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class CodigoCausaNoPago
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El codigo es obligatorio")]
        [Display(Name = "Nombre del codigo")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]       
        public string Descripcion { get; set; }

        public string Peso { get; set; }


    }
}
