using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postgrest.Attributes;
using Postgrest.Models;
namespace BlazorKioscoAlmacenes.Models
{
    [Table("kioscos")]
    public class Kiosco:BaseModel
    {
        [PrimaryKey("id", false)]
        public int? Id { get; set; }
        [Column("nombre_kiosco")]
        public string? NombreKiosco { get; set; }
        [Column("cuit_dni")]
        public string? CuitDni { get; set; }
        [Column("feha_alta")]
        public DateTime FechaAlta { get; set; }
        [Column("estado")]
        public bool? Estado { get; set; }
        [Column("fecha_vencimiento_abono")]
        public DateTime FechaVencimientoAbono { get; set; }
        [Column("dias_anticipacion_aviso")]
        public int? DiasAnticipacionAviso { get; set; }
        [Column("notas_administrativas")]
        public string? NotasAdministrativas { get; set; }
    }
}
