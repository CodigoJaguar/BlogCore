using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class Asociacion
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        //public int CodigoResultadoId { get; set; }

        ////[ForeignKey("CodigoResultadoId")]
        //public CodigoResultado CodigoResultado { get; set; }

        //public int CodigoCausaNoPagoId { get; set; }

        ////[ForeignKey("CodigoCausaNoPagoId")]
        //public CodigoResultado CodigoCausaNoPago { get; set; }


    }
}
