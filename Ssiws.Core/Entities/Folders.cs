using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[folders]")]
    public class Folders
    {
        [Map("[folder_id]")]
        public long FolderId { get; set; }
        [Map("[name]")]
        public string Name { get; set; }
        [Map("[description]")]
        public string Description { get; set; }
        [Map("[created_by_sid]")]
        public byte[] CreatedBySid { get; set; }
        [Map("[created_by_name]")]
        public string CreatedByName { get; set; }
        [Map("[created_time]")]
        public DateTimeOffset CreatedTime { get; set; }
    }
}
