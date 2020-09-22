using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[environment_permissions]")]
    public class EnvironmentPermissions
    {
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
