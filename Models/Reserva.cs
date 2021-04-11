using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Reservas")]
    public class Reserva : BaseModel
    {
        [Column("IdPelicula")]
        public int PeliculaId { get; set; }

        [Column("IdUsuario")]
        public int UsuarioId { get; set; }

        [Column("FechaDeEntrega")]
        public DateTime? FechaDeEntrega { get; set; }

        [Column("Cerrada")]
        public bool Cerrada { get; set; }

        public Pelicula Pelicula { get; set; }

        public Usuario Usuario { get; set; }
    }
}
