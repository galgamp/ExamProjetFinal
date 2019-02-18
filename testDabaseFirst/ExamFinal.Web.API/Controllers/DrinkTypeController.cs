using ExamFinal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ExamFinal.Web.API.Controllers
{
    public class DrinkTypeController : ApiController
    {
        public DrinkTypeController()
        {

        }

        public async Task<IHttpActionResult> Get()
        {
            var actualites = DrinkTypeService.Get();
            if (actualites != null)
            {
                return this.Ok(actualites);
            }
            else
            {
                return this.NotFound();
            }
        }
    }
}
