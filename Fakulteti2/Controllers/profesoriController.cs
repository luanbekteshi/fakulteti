using FakultetiDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fakulteti2.Controllers
{
    public class profesoriController : ApiController
    {
        public IEnumerable<Profesori> Get()
        {
            using (ProfesoriDbEntities entities=new ProfesoriDbEntities())
            {
                return entities.Profesoris.ToList();
            }
        }
        public HttpResponseMessage Put(int id, [FromBody] Profesori profesori)
        {
            try
            {
                using (ProfesoriDbEntities entities = new ProfesoriDbEntities())
                {
                    var entity = entities.Profesoris.FirstOrDefault(e=>e.id_p==id);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Profesori me id " +
                            id.ToString() + " nuk u gjet!");
                    }
                    else
                    {
                        entity.emri_p = profesori.emri_p;
                        entity.mbiemri_p = profesori.mbiemri_p;
                        
                        entity.titulli_p = profesori.titulli_p;
                        entity.nrtel_p = profesori.nrtel_p;
                        entity.email_p = profesori.email_p;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        //post methoda
        public HttpResponseMessage Post([FromBody]Profesori profesori)
        {
            try
            {
                using (ProfesoriDbEntities entities = new ProfesoriDbEntities())
                {
                    entities.Profesoris.Add(profesori);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, profesori);
                    message.Headers.Location = new Uri(Request.RequestUri + profesori.id_p.ToString());
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
