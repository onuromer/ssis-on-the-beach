using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Business.Interfaces
{
    public interface IAppSettings
    {
        public string ConnectionString { get; set; }
        public int CommandTimeout { get; set; }
    }
}
