using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEcomSur
{
    public class BDVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fiVentaId { get; set; }
        public int fiUsuarioId { get; set; }
        public int fiProductoId { get; set; }      
        public int fiCantidaCompra { get; set; }
        public string? fcFechaCompra { get; set; }

        [ForeignKey("fiProductoId")]
        public virtual BDProducto BDProducto { get; set; }

        [ForeignKey("fiUsuarioId")]
        public virtual BDUsuario BDUsuario { get; set; }
    }
}
