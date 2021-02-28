using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class PlayList
    {
        public static IEnumerable<playlistdto> ListarPlaylist(string nombre)
        {
            spotifyEntities db = new spotifyEntities();
            var list = from b in db.PlayLists.Where(t => t.Nombre.Contains(nombre)).OrderBy(t=>t.Nombre)
                       select new playlistdto()
                       {
                           Id = b.Id,
                           Nombre = b.Nombre,
                           Descripcion = b.Descripcion,
                           IdUsuario = b.IdUsuario,
                           Imagen = b.Imagen,
                           Acceso = b.Acceso

                       };

            return list;
        }
    }
}