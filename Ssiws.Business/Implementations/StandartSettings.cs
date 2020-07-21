using Ssiws.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Business.Implementations
{
    public class StandartSettings : IAppSettings
    {
        public string ConnectionString { get; set ; }
        public int CommandTimeout { get; set; } = 600;

        public StandartSettings()
        {

        }
    }
}
