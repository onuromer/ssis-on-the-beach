using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[customized_logging_levels]")]    
    [ControllerDetails("api/SSISDB/CustomizedLoggingLevels")]    
    public class CustomizedLoggingLevels
    {
        [Key]
        [Map("[level_id]")]         
        public long LevelId { get; set; }
        
        [Map("[name]")]         
        public string Name { get; set; }
        
        [Map("[description]")]         
        public string Description { get; set; }
        
        [Map("[profile_value]")]         
        public long ProfileValue { get; set; }
        
        [Map("[events_value]")]         
        public long EventsValue { get; set; }
        
        [Map("[created_by_sid]")]         
        public byte[] CreatedBySid { get; set; }
        
        [Map("[created_by_name]")]         
        public string CreatedByName { get; set; }
        
        [Map("[created_time]")]         
        public DateTimeOffset CreatedTime { get; set; }
    }
}
