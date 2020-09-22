using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[object_parameters]")]
    public class ObjectParameters
    {
        [Map("[parameter_id]")]
        public long ParameterId { get; set; }
        [Map("[project_id]")]
        public long ProjectId { get; set; }
        [Map("[project_version_lsn]")]
        public long ProjectVersionLsn { get; set; }
        [Map("[object_type]")]
        public short ObjectType { get; set; }
        [Map("[object_name]")]
        public string ObjectName { get; set; }
        [Map("[parameter_name]")]
        public string ParameterName { get; set; }
        [Map("[parameter_data_type]")]
        public string ParameterDataType { get; set; }
        [Map("[required]")]
        public bool Required { get; set; }
        [Map("[sensitive]")]
        public bool Sensitive { get; set; }
        [Map("[description]")]
        public string Description { get; set; }
        [Map("[design_default_value]")]
        public object DesignDefaultValue { get; set; }
        [Map("[default_value]")]
        public object DefaultValue { get; set; }
        [Map("[sensitive_default_value]")]
        public string SensitiveDefaultValue { get; set; }
        [Map("[base_data_type]")]
        public string BaseDataType { get; set; }
        [Map("[value_type]")]
        public string ValueType { get; set; }
        [Map("[value_set]")]
        public bool ValueSet { get; set; }
        [Map("[referenced_variable_name]")]
        public string ReferencedVariableName { get; set; }
        [Map("[validation_status]")]
        public string ValidationStatus { get; set; }
        [Map("[last_validation_time]")]
        public DateTimeOffset? LastValidationTime { get; set; }
    }
}
