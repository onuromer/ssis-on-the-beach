
using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[alwayson_support_state]")]    
    [ControllerDetails("api/SSISDB/AlwaysonSupportState")]    
    public class AlwaysonSupportState
    {
        [Key]
        [Map("[server_name]")]         
        public string ServerName { get; set; }
        
        [Map("[state]")]         
        public byte State { get; set; }
    }
}
