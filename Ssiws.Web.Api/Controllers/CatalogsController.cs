using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Ssiws.Business.Implementations;
using Ssiws.Business.Repositories;
using Ssiws.Core.Entities;

namespace Ssiws.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        private IOptions<StandartSettings> settings;

        public CatalogsController(IOptions<StandartSettings> settings)
        {
            this.settings = settings;
        }

        [HttpGet("/Properties")]
        public ActionResult<CatalogProperties> GetProperties()
        {
            var r = new CatalogRepository(settings.Value);

            return new ObjectResult(r.GetCatalogProperties());
        }
    }
}
