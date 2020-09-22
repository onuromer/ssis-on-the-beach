using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[projects]")]
    public class Projects
    {
        [Map("[project_id]")]
        public long ProjectId { get; set; }
        [Map("[folder_id]")]
        public long FolderId { get; set; }
        [Map("[name]")]
        public string Name { get; set; }
        [Map("[description]")]
        public string Description { get; set; }
        [Map("[project_format_version]")]
        public int? ProjectFormatVersion { get; set; }
        [Map("[deployed_by_sid]")]
        public byte[] DeployedBySid { get; set; }
        [Map("[deployed_by_name]")]
        public string DeployedByName { get; set; }
        [Map("[last_deployed_time]")]
        public DateTimeOffset LastDeployedTime { get; set; }
        [Map("[created_time]")]
        public DateTimeOffset CreatedTime { get; set; }
        [Map("[object_version_lsn]")]
        public long ObjectVersionLsn { get; set; }
        [Map("[validation_status]")]
        public string ValidationStatus { get; set; }
        [Map("[last_validation_time]")]
        public DateTimeOffset? LastValidationTime { get; set; }
    }
}
