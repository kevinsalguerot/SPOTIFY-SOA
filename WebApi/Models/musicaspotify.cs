using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class Musica
    {
        public static IEnumerable<musicadto> ListarCanciones(string nombre)
        {

            spotifyEntities db = new spotifyEntities();
            var list = from b in db.Musicas.Where(t => t.Titulo.Contains(nombre)==true)
                       select new musicadto()
                       {
                           Id = b.Id,
                           Titulo = b.Titulo,
                           Artista = b.Artista,
                           Año = b.Año,
                           Archivo = b.Archivo,
                           IdAlbum = b.IdAlbum
                           
                       };

            return list;
        }
    }
}