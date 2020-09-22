using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[data_type_mapping]")]
    public class DataTypeMapping
    {
        [Map("[mapping_id]")]
        public long MappingId { get; set; }
        [Map("[ssis_data_type]")]
        public string SsisDataType { get; set; }
        [Map("[sql_data_type]")]
        public string SqlDataType { get; set; }
    }
}
