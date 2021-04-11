using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Peliculas")]
    public class Pelicula : BaseModel
    {
        [Column("Titulo")]
        public string Titulo { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Column("Director")]
        public string Director { get; set; }

        [Column("Costo_Alquiler")]
        public decimal Costo { get; set; }

        [Column("Cantidad_Inventario")]
        public int CantidadInventario { get; set; }

        [NotMapped]
        public int CantidadDisponibles { get; set; }
    }
}
