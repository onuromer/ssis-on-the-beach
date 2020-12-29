using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[event_message_context_scaleout]")]    
    [ControllerDetails("api/v1/EventMessageContextScaleout")]    
    public class EventMessageContextScaleout
    {
        
        [Map("[context_id]")]         
        public long ContextId { get; set; }
        
        [Map("[operation_id]")]         
        public long OperationId { get; set; }
        
        [Map("[context_depth]")]         
        public int? ContextDepth { get; set; }
        
        [Map("[package_path]")]         
        public string PackagePath { get; set; }
        
        [Map("[context_type]")]         
        public short? ContextType { get; set; }
        
        [Map("[context_source_name]")]         
        public string ContextSourceName { get; set; }
        
        [Map("[context_source_id]")]         
        public string ContextSourceId { get; set; }
        
        [Map("[property_name]")]         
        public string PropertyName { get; set; }
        
        [Map("[property_value]")]         
        public object PropertyValue { get; set; }
        
        [Map("[event_message_guid]")]         
        public Guid EventMessageGuid { get; set; }
    }
}
