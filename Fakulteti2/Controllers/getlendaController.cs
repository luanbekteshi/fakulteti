using FakultetiDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fakulteti2.Controllers
{
    public class getlendaController : ApiController
    {

        public IEnumerable<vw_Lendet> Get()
        {
            using (vwLendetDbEntities entities = new vwLendetDbEntities())
            {
                return entities.vw_Lendet.ToList();
            }
        }




    }
}
