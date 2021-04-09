using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Usuarios")]
    public class Usuario : BaseModel
    {
        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Contraseña")]
        public string Contraseña { get; set; }

        [Column("Correo")]
        public string Correo { get; set; }

        [Column("Direccion")]
        public string Direccion { get; set; }

        [Column("Telefono")]
        public string Telefono { get; set; }

        [Column("IdRol")]
        public int RolId { get; set; }

        public Rol Rol { get; set; }
    }
}
