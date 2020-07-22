using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Core
{
    [Map("[catalog].[effective_object_permissions]")]
    public class EffectiveObjectPermission
    {
        [Map("object_type")]
        public short ObjectType { get; set; }
        [Map("object_id")]
        public long ObjectId { get; set; }
        [Map("permission_type ")]
        public short PermissionType { get; set; }
    }
}
