using Microsoft.AspNetCore.Mvc;
using RepoDb;
using Ssiws.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Ssiws.Web.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class BaseControllerWithId<T, K> : BaseController<T> where T : class
    {

        public BaseControllerWithId(IStorage storage) : base(storage)
        {

        }

        [HttpGet("{id}")]
        public IEnumerable<T> Get(K id)
        {
            return _storage.Tables.Query<T>(id);
        }

        [HttpPost("{id}")]
        public void Post([FromBody] T value)
        {
            _storage.Tables.Insert(value);
        }

        [HttpPut("{id}")]
        public void Put([FromBody] T value)
        {
            _storage.Tables.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete([FromBody] T value)
        {
            _storage.Tables.Delete(value);
        }
    }
}
