using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[operations]")]    
    [ControllerDetails("api/v1/Operations",typeof(long))]    
    public class Operations
    {
        [Key]
        [Map("[operation_id]")]         
        public long OperationId { get; set; }
        
        [Map("[operation_type]")]         
        public short OperationType { get; set; }
        
        [Map("[created_time]")]         
        public DateTimeOffset? CreatedTime { get; set; }
        
        [Map("[object_type]")]         
        public short? ObjectType { get; set; }
        
        [Map("[object_id]")]         
        public long? ObjectId { get; set; }
        
        [Map("[object_name]")]         
        public string ObjectName { get; set; }
        
        [Map("[status]")]         
        public int Status { get; set; }
        
        [Map("[start_time]")]         
        public DateTimeOffset? StartTime { get; set; }
        
        [Map("[end_time]")]         
        public DateTimeOffset? EndTime { get; set; }
        
        [Map("[caller_sid]")]         
        public byte[] CallerSid { get; set; }
        
        [Map("[caller_name]")]         
        public string CallerName { get; set; }
        
        [Map("[process_id]")]         
        public int? ProcessId { get; set; }
        
        [Map("[stopped_by_sid]")]         
        public byte[] StoppedBySid { get; set; }
        
        [Map("[stopped_by_name]")]         
        public string StoppedByName { get; set; }
        
        [Map("[operation_guid]")]         
        public Guid? OperationGuid { get; set; }
        
        [Map("[server_name]")]         
        public string ServerName { get; set; }
        
        [Map("[machine_name]")]         
        public string MachineName { get; set; }
        
        [Map("[worker_agent_id]")]         
        public Guid? WorkerAgentId { get; set; }
        
        [Map("[executed_count]")]         
        public int? ExecutedCount { get; set; }
    }
}
