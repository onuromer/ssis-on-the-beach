using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[extended_operation_info]")]
    public class ExtendedOperationInfo
    {
        [Map("[info_id]")]
        public long InfoId { get; set; }
        [Map("[operation_id]")]
        public long OperationId { get; set; }
        [Map("[object_name]")]
        public string ObjectName { get; set; }
        [Map("[object_type]")]
        public short? ObjectType { get; set; }
        [Map("[reference_id]")]
        public long? ReferenceId { get; set; }
        [Map("[status]")]
        public int Status { get; set; }
        [Map("[start_time]")]
        public DateTimeOffset StartTime { get; set; }
        [Map("[end_time]")]
        public DateTimeOffset? EndTime { get; set; }
    }
}
