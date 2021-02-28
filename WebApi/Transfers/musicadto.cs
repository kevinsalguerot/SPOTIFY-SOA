using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfers
{
    public class musicadto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public Nullable<int> Año { get; set; }
        public string Archivo { get; set; }
        public int IdAlbum { get; set; }
    }
}