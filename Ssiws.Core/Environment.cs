using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Core
{
    [Map("[catalog].[environments]")]
    public class Environment : Auditable
    {
        [Map("environment_id")]
        public long EnvironmenId { get; set; }
        [Map("name")]
        public string Name { get; set; }
        [Map("folder_id")]
        public long FolderId { get; set; }
        [Map("description")]
        public string Description { get; set; }

    }
}
