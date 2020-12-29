using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[operation_messages_scaleout]")]    
    [ControllerDetails("api/v1/OperationMessagesScaleout")]    
    public class OperationMessagesScaleout
    {
        
        [Map("[operation_id]")]         
        public long OperationId { get; set; }
        
        [Map("[message_time]")]         
        public DateTimeOffset MessageTime { get; set; }
        
        [Map("[message_type]")]         
        public short MessageType { get; set; }
        
        [Map("[message_source_type]")]         
        public short? MessageSourceType { get; set; }
        
        [Map("[message]")]         
        public string Message { get; set; }
        
        [Map("[extended_info_id]")]         
        public long? ExtendedInfoId { get; set; }
        
        [Map("[event_message_guid]")]         
        public Guid EventMessageGuid { get; set; }
    }
}
