using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[environments]")]
    public class Environments
    {
        [Map("[environment_id]")]
        public long EnvironmentId { get; set; }
        [Map("[environment_name]")]
        public string EnvironmentName { get; set; }
        [Map("[folder_id]")]
        public long FolderId { get; set; }
        [Map("[description]")]
        public string Description { get; set; }
        [Map("[created_by_sid]")]
        public byte[] CreatedBySid { get; set; }
        [Map("[created_by_name]")]
        public string CreatedByName { get; set; }
        [Map("[created_time]")]
        public DateTimeOffset CreatedTime { get; set; }
    }
}
