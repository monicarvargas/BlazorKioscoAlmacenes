using Postgrest.Attributes;
using Postgrest.Models;


namespace BlazorKioscoAlmacenes.Models
{
    [Table("usuarios")]
    public class Usuario:BaseModel
    {
        [PrimaryKey("id", false)]
        public string? Id { get; set; } // El UUID de Supabase

        [Column("username")]
        public string? Username { get; set; }

        [Column("password")]
        public string? Password { get; set; }

        [Column("id_kiosco")]
        public int IdKiosco { get; set; }

        [Column("rol")]
        public string? Rol { get; set; }
    }
}
