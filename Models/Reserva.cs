using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Reserva : BaseModel
    {
        public int IdPelicula { get; set; }
        public int IdUsuario { get; set; }
        public DateTime? FechaDeReserva { get; set; }
        public int DiasDeReserva { get; set; }
        public bool Cerrada { get; set; }
    }
}
