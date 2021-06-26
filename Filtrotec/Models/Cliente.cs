using System;
using System.Collections.Generic;

namespace Filtrotec.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int? IdArticulo { get; set; }

        public virtual Articulo IdArticuloNavigation { get; set; }
    }
}
