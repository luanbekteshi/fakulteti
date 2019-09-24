using FakultetiDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fakulteti2.Controllers
{
    public class LendetController : ApiController
    {

        public IEnumerable<Lenda> Get()
        {

            using (LendetDbEntities entitie=new LendetDbEntities())
            {
              return  entitie.Lendas.ToList();
            }
        }

        //post methoda
        //post methoda
        public HttpResponseMessage Post([FromBody]Lenda lenda)
        {
            try
            {
                using (LendetDbEntities entities = new LendetDbEntities())
                {
                    entities.Lendas.Add(lenda);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, lenda);
                    message.Headers.Location = new Uri(Request.RequestUri + lenda.id_l.ToString());
                    return message;
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
