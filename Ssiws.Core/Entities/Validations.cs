using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[validations]")]
    public class Validations
    {
        [Map("[validation_id]")]
        public long ValidationId { get; set; }
        [Map("[environment_scope]")]
        public string EnvironmentScope { get; set; }
        [Map("[validate_type]")]
        public string ValidateType { get; set; }
        [Map("[folder_name]")]
        public string FolderName { get; set; }
        [Map("[project_name]")]
        public string ProjectName { get; set; }
        [Map("[project_lsn]")]
        public long? ProjectLsn { get; set; }
        [Map("[use32bitruntime]")]
        public bool? Use32bitruntime { get; set; }
        [Map("[reference_id]")]
        public long? ReferenceId { get; set; }
        [Map("[job_id]")]
        public Guid? JobId { get; set; }
    }
}
