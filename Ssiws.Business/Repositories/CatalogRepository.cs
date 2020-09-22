using Microsoft.Data.SqlClient;
using RepoDb;
using Ssiws.Business.Interfaces;
using Ssiws.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Business.Repositories
{
    public class CatalogRepository:DbRepository<SqlConnection>
    {
        public CatalogRepository(IAppSettings options) : base(options.ConnectionString, options.CommandTimeout)
        {
            
        }

        public IEnumerable<CatalogProperties> GetCatalogProperties()
        {
            return QueryAll<CatalogProperties>();
        }

    }
}
