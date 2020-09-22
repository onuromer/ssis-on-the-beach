using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[execution_property_override_values]")]
    public class ExecutionPropertyOverrideValues
    {
        [Map("[property_id]")]
        public long PropertyId { get; set; }
        [Map("[execution_id]")]
        public long ExecutionId { get; set; }
        [Map("[property_path]")]
        public string PropertyPath { get; set; }
        [Map("[property_value]")]
        public string PropertyValue { get; set; }
        [Map("[sensitive_property_value]")]
        public string SensitivePropertyValue { get; set; }
        [Map("[sensitive]")]
        public bool Sensitive { get; set; }
    }
}
