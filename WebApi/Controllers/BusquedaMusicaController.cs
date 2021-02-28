using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;
using WebApi.Transfers;

namespace WebApi.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class BusquedaMusicaController : ApiController
    {
        [HttpGet]
        [Route("api/BusquedaMusica/ListarCanciones")]
        public IEnumerable<musicadto> ListarCanciones(string nombre)
        {
            return Musica.ListarCanciones(nombre);
        }

        [HttpGet]
        [Route("api/BusquedaMusica/ListarPlaylist")]
        public IEnumerable<playlistdto> ListarPlaylist(string nombre)
        {
            return PlayList.ListarPlaylist(nombre);
        }
    }
}
