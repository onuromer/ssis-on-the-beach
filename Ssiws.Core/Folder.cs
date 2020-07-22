using RepoDb.Attributes;
using System;

namespace Ssiws.Core
{
    [Map("[catalog].[folders]")]
    public class Folder: Auditable
    {
        [Map("folder_id")]
        public long FolderId { get; set; }

        [Map("name")]
        public string Name { get; set; }

        [Map("description")]
        public string Description { get; set; }
        
    }
}

