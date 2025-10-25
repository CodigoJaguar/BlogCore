using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class AsociacionResultado
    {
        [Key]
        [Column(Order = 1)]
        public int CodigoResultadoId { get; set; }

        [ForeignKey("CodigoResultadoId")]
        public CodigoResultado CodigoResultado { get; set; }

        [Key]
        [Column(Order = 2)]
        public int AsociacionId { get; set; }

        [ForeignKey("AsociacionId")]
        public Asociacion Asociacion { get; set; }
    }
}
