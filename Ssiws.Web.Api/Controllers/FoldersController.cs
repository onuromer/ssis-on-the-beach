using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Ssiws.Business.Implementations;
using Ssiws.Business.Interfaces;
using Ssiws.Business.Repositories;
using Ssiws.Core.Entities;

namespace Ssiws.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoldersController : ControllerBase
    {
        private IOptions<StandartSettings> settings;

        public FoldersController(IOptions<StandartSettings> settings)
        {
            this.settings = settings;
        }

        [HttpGet()]
        public ActionResult<Folders> Get()
        {
            var r = new FolderRepository(settings.Value);

            return new ObjectResult(r.QueryAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Folders> Get(long id)
        {
            var r = new FolderRepository(settings.Value);

            return new ObjectResult(r.Query(f => f.FolderId == id));
        }

        [HttpGet("{id}/Projects")]
        public ActionResult<Folders> GetProjects(long id)
        {
            var r = new ProjectRepository(settings.Value);

            return new ObjectResult(r.Query(p => p.FolderId == id));
        }
    }



}
