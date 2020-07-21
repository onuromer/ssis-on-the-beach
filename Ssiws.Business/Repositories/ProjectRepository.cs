using Microsoft.Data.SqlClient;
using RepoDb;
using Ssiws.Business.Interfaces;
using Ssiws.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Business.Repositories
{
    public class ProjectRepository:BaseRepository<Project,SqlConnection>
    {
        public ProjectRepository(IAppSettings options) : base(options.ConnectionString, options.CommandTimeout)
        {

        }
    }
}
