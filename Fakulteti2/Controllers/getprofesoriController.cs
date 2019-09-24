using FakultetiDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fakulteti2.Controllers
{
    public class getprofesoriController : ApiController
    {
        public IEnumerable<vw_profesori> Get()
        {
            
            using(vwProfesoriDbEntities entities=new vwProfesoriDbEntities())
            {
                return entities.vw_profesori.ToList();
            }
        }

        //public HttpResponseMessage PostProfesori([FromBody]Profesori profesori)
        //{
        //    try
        //    {
        //        using (FakultetiDbEntities entities = new FakultetiDbEntities())
        //        {
        //            entities.Profesoris.Add(profesori);
        //            entities.SaveChanges();
        //            var message = Request.CreateResponse(HttpStatusCode.Created, profesori);
        //            message.Headers.Location = new Uri(Request.RequestUri + profesori.id_p.ToString());
        //            return message;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        

    }
}
