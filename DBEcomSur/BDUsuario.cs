using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEcomSur
{
    public class BDUsuario

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fiId { get; set; }
        public int fiUsuarioId { get; set; }      
        public string? fcNombre { get; set; }
        public string? fcAmaterno { get; set; }
        public string? fcApaterno { get; set; }
        public string? fcCalle { get;set; }
        public string? fcNumero { get; set; }
        public string? fcColonia { get; set; }
        public string? fcFechaCreacion { get; set; }
        public int fiIdRol { get; set; }

    }
}
