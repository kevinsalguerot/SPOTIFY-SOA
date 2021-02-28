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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FacturacionController : ApiController
    {

        [HttpGet]
        [Route("api/Facturacion/ListarPlanes")]
        public IEnumerable<planesdto> ListarPlanes()
            {
                return Plane.ListarPlanes();
            }

    }
}
