using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Ssiws.Business.Implementations;
using Ssiws.Business.Repositories;
using Ssiws.Core;

namespace Ssiws.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private IOptions<StandartSettings> settings;

        public ProjectsController(IOptions<StandartSettings> settings)
        {
            this.settings = settings;
        }

        [HttpGet()]
        public ActionResult<Project> Get()
        {
            var r = new ProjectRepository(settings.Value);

            return new ObjectResult(r.QueryAll());
        }
        [HttpGet("{id}")]
        public ActionResult<Project> Get(long id)
        {
            var r = new ProjectRepository(settings.Value);

            return new ObjectResult(r.Query(p=>p.ProjectId==id));
        }
    }
}
