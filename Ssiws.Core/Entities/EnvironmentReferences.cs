using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[environment_references]")]    
    [ControllerDetails("api/SSISDB/EnvironmentReferences")]    
    public class EnvironmentReferences
    {
        [Key]
        [Map("[reference_id]")]         
        public long ReferenceId { get; set; }
        
        [Map("[project_id]")]         
        public long ProjectId { get; set; }
        
        [Map("[reference_type]")]         
        public string ReferenceType { get; set; }
        
        [Map("[environment_folder_name]")]         
        public string EnvironmentFolderName { get; set; }
        
        [Map("[environment_name]")]         
        public string EnvironmentName { get; set; }
        
        [Map("[validation_status]")]         
        public string ValidationStatus { get; set; }
        
        [Map("[last_validation_time]")]         
        public DateTimeOffset? LastValidationTime { get; set; }
    }
}
