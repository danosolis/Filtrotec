using System;
using System.Collections.Generic;

namespace Filtrotec.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdArticulo { get; set; }
        public int? Codigo { get; set; }
        public string Descripcion { get; set; }
        public double? Precio { get; set; }
        public byte[] Imagen { get; set; }
        public string Stock { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? IdTienda { get; set; }

        public virtual Tienda IdTiendaNavigation { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
