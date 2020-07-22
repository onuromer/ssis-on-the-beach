using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[environment_variables]")]
    public class EnvironmentVariables
    {
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
