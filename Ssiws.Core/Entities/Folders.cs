using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[folders]")]    
    [ControllerDetails("api/SSISDB/Folders")]    
    public class Folders
    {
        [Key]
        [Map("[folder_id]")]         
        public long FolderId { get; set; }
        
        [Map("[name]")]         
        public string Name { get; set; }
        
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
