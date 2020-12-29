using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RepoDb;
using Ssiws.Business.Implementations;
using Ssiws.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Ssiws.Web.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class BaseController<T> : Controller where T : class
    {
        internal IStorage _storage;

        public BaseController(IStorage storage )
        {
            _storage = storage;
        }

        [HttpGet]
        public IEnumerable<T> Get()
        {
            return _storage.Tables.QueryAll<T>();
        }
    }
}
