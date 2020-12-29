using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[data_type_mapping]")]    
    [ControllerDetails("api/SSISDB/DataTypeMapping")]    
    public class DataTypeMapping
    {
        [Key]
        [Map("[mapping_id]")]         
        public long MappingId { get; set; }
        
        [Map("[ssis_data_type]")]         
        public string SsisDataType { get; set; }
        
        [Map("[sql_data_type]")]         
        public string SqlDataType { get; set; }
    }
}
