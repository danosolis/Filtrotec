using System;
using System.Collections.Generic;

namespace Filtrotec.Models
{
    public partial class Tienda
    {
        public Tienda()
        {
            Articulo = new HashSet<Articulo>();
        }

        public int IdTienda { get; set; }
        public string Sucursal { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Articulo> Articulo { get; set; }
    }
}
