
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postgrest.Attributes;
using Postgrest.Models;
namespace BlazorKioscoAlmacenes.Models
{
    [Table("familias")]
    public class Familia:BaseModel
    {
        [PrimaryKey("id",false)]
        public int? Id { get; set; }
        [Column("kiosco_id")]
        public int? KioscoId { get; set; }
        [Column("nombre")]
        public string? Nombre { get; set; }
        [Column("descripcion")]
        public string? Descripcion { get; set; }
        [Column("created_ad")]
        public DateTime fechaCreacion { get; set; }
    }
}
