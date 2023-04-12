using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEcomSur
{
    public class BDProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fiProductoId { get; set; }
        public string? fcProducto{ get; set; }
        public double fdPrecio { get; set; }
        public int fiCantidadProducto { get; set; }

    }
}
