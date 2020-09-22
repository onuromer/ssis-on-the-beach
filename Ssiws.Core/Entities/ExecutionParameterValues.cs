using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[execution_parameter_values]")]
    public class ExecutionParameterValues
    {
        [Map("[execution_parameter_id]")]
        public long ExecutionParameterId { get; set; }
        [Map("[execution_id]")]
        public long ExecutionId { get; set; }
        [Map("[object_type]")]
        public short ObjectType { get; set; }
        [Map("[parameter_data_type]")]
        public string ParameterDataType { get; set; }
        [Map("[parameter_name]")]
        public string ParameterName { get; set; }
        [Map("[parameter_value]")]
        public object ParameterValue { get; set; }
        [Map("[sensitive_parameter_value]")]
        public string SensitiveParameterValue { get; set; }
        [Map("[base_data_type]")]
        public string BaseDataType { get; set; }
        [Map("[sensitive]")]
        public bool Sensitive { get; set; }
        [Map("[required]")]
        public bool Required { get; set; }
        [Map("[value_set]")]
        public bool ValueSet { get; set; }
        [Map("[runtime_override]")]
        public bool RuntimeOverride { get; set; }
    }
}
