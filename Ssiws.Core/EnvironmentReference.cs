using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Core
{
    [Map("[catalog].[environment_references]")]
    public class EnvironmentReference
    {
        [Map("reference_id")]
        public long ReferenceId { get; set; }        
        [Map("project_id")]
        public long ProjectId { get; set; }
        [Map("reference_type")]
        public char ReferenceType { get; set; }
        [Map("environment_folder_name")]
        public string EnvironmentFolderName { get; set; }
        [Map("environment_name")]
        public string EnvironmentName { get; set; }
        [Map("validation_status")]
        public char ValidationStatus { get; set; }        
        [Map("last_validation_time")]
        public DateTimeOffset? LastValidationTime { get; set; }
    }
}
