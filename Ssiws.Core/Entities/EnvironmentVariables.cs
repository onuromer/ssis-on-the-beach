using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[environment_variables]")]    
    [ControllerDetails("api/SSISDB/EnvironmentVariables")]    
    public class EnvironmentVariables
    {
        [Key]
        [Map("[variable_id]")]         
        public long VariableId { get; set; }
        
        [Map("[environment_id]")]         
        public long EnvironmentId { get; set; }
        
        [Map("[name]")]         
        public string Name { get; set; }
        
        [Map("[description]")]         
        public string Description { get; set; }
        
        [Map("[type]")]         
        public string Type { get; set; }
        
        [Map("[sensitive]")]         
        public bool Sensitive { get; set; }
        
        [Map("[value]")]         
        public object Value { get; set; }
        
        [Map("[sensitive_value]")]         
        public string SensitiveValue { get; set; }
        
        [Map("[base_data_type]")]         
        public string BaseDataType { get; set; }
    }
}
