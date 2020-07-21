using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Core
{
    [Map("[catalog].[projects]")]
    public class Project
    {
        [Map("project_id")]
        public long ProjectId { get; set; }
        [Map("folder_id")]
        public long FolderId { get; set; }
        [Map("name")]
        public string Name { get; set; }
        [Map("description")]
        public string Description { get; set; }
        [Map("project_format_version")]
        public int? ProjectFormatVersion { get; set; }
        [Map("deployed_by_sid")]
        public Byte[] DeployedBySID { get; set; }
        [Map("deployed_by_name")]
        public string DeployedByName { get; set; }
        [Map("last_deployed_time")]
        public DateTime LastDeployedTime { get; set; }
        [Map("created_time")]
        public DateTime CreatedTime { get; set; }
        [Map("object_version_lsn")]
        public long ObjectVersionLSN { get; set; }
        [Map("validation_status")]
        public char ValidationStatus { get; set; }
        [Map("last_validation_time")]
        public DateTime? LastValidationTime { get; set; }
    }
}
