using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class Plane
    {
        public static IEnumerable<planesdto> ListarPlanes()
        {
            spotifyEntities db = new spotifyEntities();
            var list = from b in db.Planes.OrderBy(t => t.Precio)
                       select new planesdto()
                       {
                           Id = b.Id,
                           Nombre = b.Nombre,
                           Detalle = b.Detalle,
                           Precio = b.Precio,
                           Moneda = b.Moneda,
                          

                       };

            return list;
        }
    }
}