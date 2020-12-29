using RepoDb;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Ssiws.Business.Interfaces
{
    public interface IStorage
    {
        DbRepository<SqlConnection> Tables { get; set; }
    }
}
