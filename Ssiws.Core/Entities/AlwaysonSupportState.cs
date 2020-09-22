
using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[alwayson_support_state]")]
    public class AlwaysonSupportState
    {
        [Map("[server_name]")]
        public string ServerName { get; set; }
        [Map("[state]")]
        public byte State { get; set; }
    }
}
