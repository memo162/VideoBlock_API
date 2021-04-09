using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Roles")]
    public class Rol : BaseModel
    {
        [Column("Nombre")]
        public string Nombre { get; set; }
    }
}
