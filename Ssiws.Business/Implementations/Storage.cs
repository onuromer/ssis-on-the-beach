using RepoDb;
using Ssiws.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Ssiws.Business.Implementations
{
    public class Storage : IStorage
    {
        public DbRepository<SqlConnection> Tables { get; set; }
        private IAppSettings settings;

        public Storage(IAppSettings settings)
        {
            this.settings = settings;
            Tables = new DbRepository<SqlConnection>(settings.ConnectionString);
        }

    }
}
