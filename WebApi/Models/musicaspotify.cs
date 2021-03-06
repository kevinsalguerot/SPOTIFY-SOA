using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        public static musicadto ObtenerMusica(int id)
        {
            spotifyEntities db = new spotifyEntities();
            var obj = db.Musicas.Select(b =>
                    new musicadto()
                    {
                        Id = b.Id,
                        Titulo = b.Titulo,
                        Artista = b.Artista,
                        Año = b.Año,
                        Archivo = b.Archivo,
                        IdAlbum = b.IdAlbum
                    }).SingleOrDefault(b => b.Id == id);
            if (obj == null) obj = new musicadto() { Id = 0, Titulo = "", Artista = "", Año = null, Archivo = "", IdAlbum = 0 };
            return obj;
        }
        public static musicadto RegistrarMusica(musicadto musicadto)
        {
            spotifyEntities db = new spotifyEntities();
            Musica musica = new Musica()
            {
                           Titulo = musicadto.Titulo,
                           Artista = musicadto.Artista,
                           Año = musicadto.Año,
                           Archivo = musicadto.Archivo,
                           IdAlbum = musicadto.IdAlbum
            };
            db.Musicas.Add(musica);
            db.SaveChanges();
            return Musica.ObtenerMusica(musica.Id);
        }

        public static musicadto ActualizarMusica(int id,musicadto musicadto)
        {
            spotifyEntities db = new spotifyEntities();
            Musica musica = db.Musicas.Find(id);
            musica.Titulo = musicadto.Titulo;
            musica.Artista = musicadto.Artista;
            musica.Año = musicadto.Año;
            db.Entry(musica).State = EntityState.Modified;
            db.SaveChanges();
            return Musica.ObtenerMusica(musica.Id);
        }
    }
}