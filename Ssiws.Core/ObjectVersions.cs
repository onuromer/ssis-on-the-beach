using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[object_versions]")]
    public class ObjectVersions
    {
        [Map("[object_version_lsn]")]
        public long ObjectVersionLsn { get; set; }
        [Map("[object_id]")]
        public long ObjectId { get; set; }
        [Map("[object_type]")]
        public short ObjectType { get; set; }
        [Map("[description]")]
        public string Description { get; set; }
        [Map("[created_by]")]
        public string CreatedBy { get; set; }
        [Map("[created_time]")]
        public DateTimeOffset CreatedTime { get; set; }
        [Map("[restored_by]")]
        public string RestoredBy { get; set; }
        [Map("[last_restored_time]")]
        public DateTimeOffset? LastRestoredTime { get; set; }
        [Map("[object_data]")]
        public string ObjectData { get; set; }
        [Map("[object_status]")]
        public string ObjectStatus { get; set; }
    }
}
