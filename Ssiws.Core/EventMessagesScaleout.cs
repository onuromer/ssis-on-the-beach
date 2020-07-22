using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[event_messages_scaleout]")]
    public class EventMessagesScaleout
    {
        [Map("[operation_id]")]
        public long OperationId { get; set; }
        [Map("[execution_path]")]
        public string ExecutionPath { get; set; }
        [Map("[package_name]")]
        public string PackageName { get; set; }
        [Map("[package_location_type]")]
        public string PackageLocationType { get; set; }
        [Map("[package_path_full]")]
        public string PackagePathFull { get; set; }
        [Map("[event_name]")]
        public string EventName { get; set; }
        [Map("[message_source_name]")]
        public string MessageSourceName { get; set; }
        [Map("[message_source_id]")]
        public string MessageSourceId { get; set; }
        [Map("[subcomponent_name]")]
        public string SubcomponentName { get; set; }
        [Map("[package_path]")]
        public string PackagePath { get; set; }
        [Map("[threadID]")]
        public int Threadid { get; set; }
        [Map("[message_code]")]
        public int? MessageCode { get; set; }
        [Map("[event_message_guid]")]
        public Guid? EventMessageGuid { get; set; }
    }
}
