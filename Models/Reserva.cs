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

        [Column("FechaDeReserva")]
        public DateTime? FechaDeReserva { get; set; }

        [Column("DiasDeReserva")]
        public int DiasDeReserva { get; set; }

        [Column("Cerrada")]
        public bool Cerrada { get; set; }

        public Pelicula Pelicula { get; set; }

        public Usuario Usuario { get; set; }
    }
}
