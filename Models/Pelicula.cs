using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Peliculas")]
    public class Pelicula
    {
        public int Id { get; set; }

        [Column("Titulo")]
        public string Titulo { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Column("Director")]
        public string Director { get; set; }

        [Column("Costo_Alquiler")]
        public decimal Costo { get; set; }

        [Column("Cantidad_Inventario")]
        public int Cantidad { get; set; }
    }
}
