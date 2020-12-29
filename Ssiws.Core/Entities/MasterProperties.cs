using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[master_properties]")]    
    [ControllerDetails("api/SSISDB/MasterProperties")]    
    public class MasterProperties
    {
        [Key]
        [Map("[property_name]")]         
        public string PropertyName { get; set; }
        
        [Map("[property_value]")]         
        public string PropertyValue { get; set; }
    }
}
