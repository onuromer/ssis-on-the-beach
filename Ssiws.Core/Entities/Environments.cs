using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[environments]")]    
    [ControllerDetails("api/SSISDB/Environments")]    
    public class Environments
    {
        [Key]
        [Map("[environment_id]")]         
        public long EnvironmentId { get; set; }
        
        [Map("[environment_name]")]         
        public string EnvironmentName { get; set; }
        
        [Map("[folder_id]")]         
        public long FolderId { get; set; }
        
        [Map("[description]")]         
        public string Description { get; set; }
        
        [Map("[created_by_sid]")]         
        public byte[] CreatedBySid { get; set; }
        
        [Map("[created_by_name]")]         
        public string CreatedByName { get; set; }
        
        [Map("[created_time]")]         
        public DateTimeOffset CreatedTime { get; set; }
    }
}
