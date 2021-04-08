using System;

namespace Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public bool Eliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
