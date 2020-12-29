using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[environment_permissions]")]    
    [ControllerDetails("api/SSISDB/EnvironmentPermissions")]    
    public class EnvironmentPermissions
    {
        [Key]
        [Map("[id]")]         
        public long Id { get; set; }
        
        [Map("[sid]")]         
        public string Sid { get; set; }
        
        [Map("[object_id]")]         
        public long ObjectId { get; set; }
        
        [Map("[permission_type]")]         
        public short PermissionType { get; set; }
        
        [Map("[is_role]")]         
        public bool IsRole { get; set; }
        
        [Map("[is_deny]")]         
        public bool IsDeny { get; set; }
        
        [Map("[grantor_sid]")]         
        public string GrantorSid { get; set; }
    }
}
